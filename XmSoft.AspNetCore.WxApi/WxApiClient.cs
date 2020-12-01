using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Request.Intelligent;
using XmSoft.AspNetCore.WxApi.Request.CustomerMessage;
using XmSoft.AspNetCore.WxApi.Request.CustomerServer;
using XmSoft.AspNetCore.WxApi.Request.Security;
using XmSoft.AspNetCore.WxApi.Request.MaterialManager;
using XmSoft.AspNetCore.WxApi.Request.Card;
using XmSoft.AspNetCore.WxApi.Response;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Request.QRCode;


namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 执行操作
    /// </summary>
    public class WxApiClient : IDisposable, IWxApiClient
    {
       
        private const string access_token = "access_token";
        private const string type = "type";
        private const string media_path = "media_path";
        private const string kf_account = "kf_account";
        private const string description = "description";
        private const string mediatype ="video";
        //private const string imagetype = "image/jpg";
        //private const string voicetype = "audio/mp3";

        private const string format = "format";
        private const string voice_id = "voice_id";
        private const string lang = "lang";

        private const string lfrom = "lfrom";
        private const string lto = "lto";

        private const string body = "body";
        /// <summary>
        /// WxApi Client
        /// </summary>
        public WxApiClient()
        {
        }
        /// <summary>
        /// 异步执行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">请求对象</param>
        /// <returns></returns>
        public async Task<T> ExecuteAsync<T>(IWxApiRequest<T> request) where T : WxApiResponse
        {
            try
            {
                var sortedParams = new WxApiDictionary(request.GetParameters());
                var content = Utility.BulidContent(sortedParams);
                var IsPost = request.IsPost();
                var url = !IsPost ? $"{request.GetRequestUrl()}?{content}" : request.GetRequestUrl();
                var filterKey = new List<string>(); // Post 中进行过滤掉的请求参数

                if (IsPost)
                {
                    
                    //判断是否存在access_token参数
                    if (sortedParams.ContainsKey(access_token))
                    {
                        filterKey.Add(access_token);
                        url += $"?{access_token}={sortedParams.GetValue(access_token)}";
                        if (sortedParams.ContainsKey(type) && !(request is WxApiGetMaterialListRequest))
                        {
                          
                            url += $"&{type }={sortedParams.GetValue(type)}";
                            filterKey.Add(type);
                        }
                        if (sortedParams.ContainsKey(kf_account) && request is WxApiSetCustomerHeadImgRequest)//设置客服帐号的头像 -特殊
                        {
                            url += $"&{kf_account }={sortedParams.GetValue(kf_account)}";
                            filterKey.Add(kf_account);
                        }
                        if(request is WxApiTranslateContentRequest) //微信翻译
                        {
                            url += $"&{lfrom }={sortedParams.GetValue(lfrom)}";
                            filterKey.Add(lfrom);
                            url += $"&{lto}={sortedParams.GetValue(lto)}";
                            filterKey.Add(lto);
                        }
                        if(request is WxApiAddVoiceTorecofortextRequest)//提交语音
                        {
                            url += $"&{format}={sortedParams.GetValue(format)}";
                            filterKey.Add(format);
                            url += $"&{voice_id}={sortedParams.GetValue(voice_id)}";
                            filterKey.Add(voice_id);
                            url += $"&{lang}={sortedParams.GetValue(lang)}";
                            filterKey.Add(lang);
                        }
                        

                    }
                }

                var client = new RestClient(url);
                var restRequest = new RestRequest(!IsPost ? Method.GET : Method.POST)
                {
                    Timeout = 10000
                };
                if (IsPost)
                {
                    
                    //判断文件是否存在
                    if (!string.IsNullOrEmpty(sortedParams.GetValue(media_path)?.ToString()) && System.IO.File.Exists(media_path))
                    {
                        /////把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
                        if (request is WxApiUploadTempMediaRequest || request is WxApiSetCustomerHeadImgRequest
                            || request is WxApiImgSecCheckRequest || request is WxApiUploadImgRequest
                            || request is WxApiUploadMaterialRequest || request is WxApiTranslateContentRequest)
                        {

                            var fileType = System.IO.Path.GetExtension(sortedParams.GetValue(media_path).ToString());
                            var media_type = sortedParams.GetValue(type).ToString();
                            var contentType = "application/x-www-form-urlencoded;charset=UTF-8";
                            //restRequest.AddFile(media_type == mediatype?"media": $"{Guid.NewGuid().ToString("N")}{fileType}", sortedParams.GetValue(media_path), contentType);
                            restRequest.AddFile("media", sortedParams.GetValue(media_path).ToString(), contentType);
                            

                            if (request is WxApiUploadMaterialRequest && media_type == mediatype)
                            {

                                restRequest.AddParameter(description, sortedParams.GetValue(description));

                            }
                        }
                    }
                    //else if(request is WxApiCreateLandingPageRequest)
                    //{
                    //    content = Utility.BulidJsonContent(sortedParams, filterKey);
                    //    var bytes = System.Text.Encoding.Default.GetBytes(content);
                    //    var contentType = "application/x-www-form-urlencoded;charset=UTF-8";
                    //    //restRequest.AddFile(media_type == mediatype?"media": $"{Guid.NewGuid().ToString("N")}{fileType}", sortedParams.GetValue(media_path), contentType);
                    //    restRequest.AddFileBytes("buffer", bytes, contentType);
                    //}
                    else
                    {
                        var contentType = "application/json;charset=UTF-8";
                        if (sortedParams.ContainsKey(body)) //参数中是否包含 body 字符串，不是Json数据
                        {
                            contentType = "text/plain";
                            content = sortedParams.GetValue(body).ToString();
                        }
                        else
                            content = Utility.BulidJsonContent(sortedParams, filterKey);

                        if (!string.IsNullOrEmpty(content))
                            restRequest.AddParameter(contentType, content, ParameterType.RequestBody);
                    }
                }



                using (var t = client.ExecuteTaskAsync(restRequest))
                {
                    t.Wait();
                    var response = await t;
                    if (request is WxApiGetTempMediaRequest || request is WxApiShowQRCodeRequest || request is WxApiGetMaterialRequest)
                    {

                        if (!response.ContentType.Contains("json") && !response.ContentType.Contains("text"))
                        {
                            var contenttype = response.ContentType;

                            //判断返回的类型是否为空，若为空，根据数据获取对应的文件类型
                            if(string.IsNullOrEmpty(response.ContentType)) 
                               contenttype = FileContentType.Get(response.RawBytes);
                            
                            //获取永久素材返回
                            if (request is WxApiGetMaterialRequest)
                            {
                                return new WxApiGetMaterialResponse
                                {
                                    ErrCode = 0,
                                    Errmsg = "",
                                    Buffer = response.RawBytes,
                                    ContentType = string.IsNullOrEmpty(response.ContentType) ? contenttype : response.ContentType

                                } as T;
                            }
                            return new WxApiFileResponse
                            {
                                ErrCode = 0,
                                Errmsg = "",
                                Buffer = response.RawBytes,
                                ContentType = string.IsNullOrEmpty(response.ContentType) ? contenttype : response.ContentType

                            } as T;
                        }
                    }
                    return JsonConvert.DeserializeObject<T>(response.Content);
                }

            }
            catch
            {
               
            }
            return null;

        }

        /// <summary>
        /// /析构函数
        /// </summary>
        ~WxApiClient()
        {
            Dispose(false);
        }
        /// <summary>
        /// 释放该接口
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 用以释放非托管资源 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //释放托管资源
            }
            //释放非托管资源
        }
    }
}
