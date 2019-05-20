using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Request.CustomerMessage;
using XmSoft.AspNetCore.WxApi.Request.CustomerServer;
using XmSoft.AspNetCore.WxApi.Request.Security;
using XmSoft.AspNetCore.WxApi.Request.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;
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
        /// <param name="UploadFilePath">文件绝对路径</param>
        /// <returns></returns>
        public async Task<T> ExecuteAsync<T>(IWxApiRequest<T> request) where T : WxApiResponse
        {
            try
            {
                var sortedParams = new WxApiDictionary(request.GetParameters());
                var content = Utility.BulidContent(sortedParams);
                var IsPost = request.IsPost();
                var url = !IsPost ? $"{request.GetRequestUrl()}?{content}" : request.GetRequestUrl();

                if (IsPost)
                {
                    //判断是否存在access_token参数
                    if (sortedParams.ContainsKey(access_token))
                    {
                        url += $"?{access_token}={sortedParams.GetValue(access_token)}";
                        if (sortedParams.ContainsKey(type) && !(request is WxApiGetMaterialListRequest))
                            url += $"&{type }={sortedParams.GetValue(type)}";
                        if(sortedParams.ContainsKey(kf_account))//设置客服帐号的头像 -特殊
                            url += $"&{kf_account }={sortedParams.GetValue(kf_account)}";
                    }
                }

                var client = new RestClient(url);
                var restRequest = new RestRequest(!IsPost ? Method.GET : Method.POST)
                {
                    Timeout = 10000
                };
                if (IsPost)
                {
                    //把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
                    if (request is WxApiUploadTempMediaRequest || request is WxApiSetCustomerHeadImgRequest
                        || request is WxApiImgSecCheckRequest || request is WxApiUploadImgRequest 
                        || request is WxApiUploadMaterialRequest)
                    {

                        var fileType = System.IO.Path.GetExtension(sortedParams.GetValue(media_path));
                        var media_type = sortedParams.GetValue(type);
                        var contentType = "application/x-www-form-urlencoded;charset=UTF-8";
                        restRequest.AddFile(media_type == mediatype?"media": $"{Guid.NewGuid().ToString("N")}{fileType}", sortedParams.GetValue(media_path), contentType);
                        
                        if(request is WxApiUploadMaterialRequest && media_type == mediatype)
                        {
                            
                            restRequest.AddParameter(description, sortedParams.GetValue(description));

                        }
                    }
                   
                    else
                    {
                        var contentType = "application/json;charset=UTF-8";
                        content = Utility.BulidJsonContent(sortedParams);
                        if(!string.IsNullOrEmpty(content))
                           restRequest.AddParameter(contentType, content, ParameterType.RequestBody);
                    }
                }



                using (var t = client.ExecuteTaskAsync(restRequest))
                {
                    t.Wait();
                    var response = await t;
                    if (request is WxApiGetTempMediaRequest || request is WxApiShowQRCodeRequest)
                    {
                        if (!response.Content.Contains("errcode"))
                        {
                            return new WxApiFileResponse
                            {
                                ErrCode = 0,
                                Errmsg = "",
                                Buffer = response.RawBytes,
                                ContentType = response.ContentType

                            } as T;
                        }
                    }
                    return JsonConvert.DeserializeObject<T>(response.Content);
                }

            }
            catch (Exception ex)
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
