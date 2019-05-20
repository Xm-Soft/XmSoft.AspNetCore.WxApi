using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 上传图片
    /// </summary>
    public class WxApiUploadImgRequest: IWxApiRequest<WxApiUploadImgResponse>
    {
        /// <summary>
        /// 上传图片请求参数 -- 公众平台
        /// <para>本接口所上传的图片不占用公众号的素材库中图片数量的5000个的限制。图片仅支持jpg/png格式，大小必须在1MB以下。</para>
        /// </summary>
        public WxApiUploadImgRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 图片本地绝对路径
        /// </summary>
        public string MediaPath { get; set; }

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
                { "access_token", AccessToken },
                {"media_path",MediaPath }
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
