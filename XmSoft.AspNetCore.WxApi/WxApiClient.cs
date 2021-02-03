using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 执行操作
    /// </summary>
    public class WxApiClient : IDisposable, IWxApiClient
    {
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
                var sortedParams = new WxApiDictionary(request.GetParameters());  //Url  参数
                var bodyParams = new WxApiDictionary(request.GetBodyParametes()); //Body 参数
                var content = Utility.BulidContent(sortedParams);
                var IsPost = request.IsPost();
                var url = !string.IsNullOrEmpty(content) ? $"{request.GetRequestUrl()}?{content}" : request.GetRequestUrl();

                var client = new RestClient(url);
                var restRequest = new RestRequest(!IsPost ? Method.GET : Method.POST)
                {
                    Timeout = 12000
                };
                if (IsPost)
                {
                    //把媒体文件上传到微信服务器
                    //设置客服帐号的头像
                    //提交语音
                    //微信翻译
                    //上传图片
                    //新增其他类型永久素材
                    //校验一张图片是否含有违法违规内容
                    if (!string.IsNullOrEmpty(bodyParams.GetValue(Constants.Media_path)?.ToString()) && System.IO.File.Exists(Constants.Media_path))
                    {
                        var fileType = System.IO.Path.GetExtension(bodyParams.GetValue(Constants.Media_path).ToString());
                        var media_type = bodyParams.GetValue(Constants.Type).ToString();
                        restRequest.AddFile("media", bodyParams.GetValue(Constants.Media_path).ToString(), Constants.ContentType_Form);

                        if (media_type == Constants.Mediatype)
                        {
                            restRequest.AddParameter(Constants.Description, bodyParams.GetValue(Constants.Description));
                        }
                    }
                    else
                    {
                        var body = string.Empty;
                        var contentType = Constants.ContentType_Json;
                        if (bodyParams.ContainsKey(Constants.Body)) //参数中是否包含 body 字符串，不是Json数据
                        {
                            contentType = Constants.ContentType_Text;
                            body = bodyParams.GetValue(Constants.Body).ToString();
                        }
                        else
                        {
                            body = Utility.BulidJsonContent(bodyParams, new List<string>());
                        }

                        if (!string.IsNullOrEmpty(body))
                        {
                            restRequest.AddParameter(contentType, body, ParameterType.RequestBody);
                        }
                    }
                }

                var response = await client.ExecuteTaskAsync(restRequest);


                if (!response.ContentType.Contains(Constants.Json) && !response.ContentType.Contains(Constants.Text))
                {
                    var contenttype = response.ContentType;

                    //判断返回的类型是否为空，若为空，根据数据获取对应的文件类型
                    if (string.IsNullOrEmpty(response.ContentType)) contenttype = FileContentType.Get(response.RawBytes);

                    return new
                    {
                        ErrCode = 0,
                        Errmsg = "",
                        Buffer = response.RawBytes,
                        ContentType = string.IsNullOrEmpty(response.ContentType) ? contenttype : response.ContentType

                    } as T;
                }

                return JsonConvert.DeserializeObject<T>(response.Content);

            }
            catch (WxApiException ex)
            {
                throw new WxApiException(ex.Message);
            }

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
