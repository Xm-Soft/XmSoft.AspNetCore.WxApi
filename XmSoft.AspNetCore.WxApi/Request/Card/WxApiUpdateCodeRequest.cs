using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///更改Code接口
    /// </summary>
    public class WxApiUpdateCodeRequest : IWxApiRequest<WxApiUpdateCodeResponse>
    {

        /// <summary>
        ///更改Code接口 公众平台
        ///为确保转赠后的安全性，微信允许自定义Code的商户对已下发的code进行更改。 
        ///<para>注：为避免用户疑惑，建议仅在发生转赠行为后（发生转赠后，微信会通过事件推送的方式告知商户被转赠的卡券Code）对用户的Code进行更改。</para>
        /// </summary>
        public WxApiUpdateCodeRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 	卡券ID。自定义Code码卡券为必填。
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 	需变更的Code码。
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 变更后的有效Code码。
        /// </summary>
        public string New_code { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/code/update";
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
                { "new_code",New_code }
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
