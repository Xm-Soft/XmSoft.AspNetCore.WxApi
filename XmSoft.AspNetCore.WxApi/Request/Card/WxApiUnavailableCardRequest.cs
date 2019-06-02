using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///设置卡券失效接口
    /// </summary>
    public class WxApiUnavailableCardRequest : IWxApiRequest<WxApiUnavailableCardResponse>
    {

        /// <summary>
        ///设置卡券失效接口 
        ///<para>为满足改票、退款等异常情况，可调用卡券失效接口将用户的卡券设置为失效状态。</para>
        /// </summary>
        public WxApiUnavailableCardRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 	设置失效的Code码。
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 失效理由 比如：用户发生退款
        /// </summary>
        public string Reason { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/code/unavailable";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "card_id",Card_id },
                { "code",Code },
                { "reason",Reason }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
}
