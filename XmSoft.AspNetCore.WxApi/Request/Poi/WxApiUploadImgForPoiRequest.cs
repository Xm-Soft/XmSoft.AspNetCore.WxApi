using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Poi;

namespace XmSoft.AspNetCore.WxApi.Request.Poi
{
    /// <summary>
    /// 创建门店-上传图片
    /// </summary>
    public class WxApiUploadImgForPoiRequest: IWxApiRequest<WxApiUploadImgForPoiResponse>
    {
        /// <summary>
        /// 创建门店-上传图片请求参数 -- 公众平台
        /// </summary>
        public WxApiUploadImgForPoiRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 图片本地绝对路径
        /// </summary>
        public string ImgPath { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/media/uploadimg";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
}
