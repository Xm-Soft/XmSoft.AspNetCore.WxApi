using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 登录凭证校验。通过 wx.login() 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程
    /// </summary>
    public class WxApiCode2SessionRequest: IWxApiRequest<WxApiCode2SessionResponse>
    {
        /// <summary>
        /// 登录凭证校验。通过 wx.login() 接口获得临时登录凭证 code 后传到开发者服务器调用此接口完成登录流程
        /// </summary>
        public WxApiCode2SessionRequest()
        {
            GrantType = "authorization_code";
        }
        /// <summary>
        /// 小程序 appId
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 小程序 appSecret
        /// </summary>

        public string Secret { get; set; }
        /// <summary>
        ///登录时获取的 code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 授权类型，此处只需填写 authorization_code
        /// </summary>
        public string GrantType { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/sns/jscode2session";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "appid", AppId },
                { "secret", Secret },
                { "js_code", Code },
                { "grant_type", GrantType }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return false;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            return new WxApiDictionary();
        }

        #endregion
    }
}
