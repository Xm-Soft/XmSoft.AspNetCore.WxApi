using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.User;

namespace XmSoft.AspNetCore.WxApi.Request.User
{
    /// <summary>
    /// 创建用户标签 - 公众平台
    /// </summary>
    public class WxApiUserCreateTagRequest : IWxApiRequest<WxApiUserCreateTagResponse>
    {
        /// <summary>
        /// 创建用户标签 - 公众平台 (一个公众号，最多可以创建100个标签。)
        /// </summary>
        public WxApiUserCreateTagRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public TagRequest Tag { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/tags/create";
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
                { "tag", Tag }
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

    public class TagRequest
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string name { get; set; }
    }
}
