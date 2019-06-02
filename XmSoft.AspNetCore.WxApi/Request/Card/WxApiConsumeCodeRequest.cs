using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///核销Code接口
    /// </summary>
    public class WxApiConsumeCodeRequest : IWxApiRequest<WxApiConsumeCodeResponse>
    {

        /// <summary>
        ///核销Code接口-- 核销卡券 公众平台
        ///消耗code接口是核销卡券的唯一接口,开发者可以调用当前接口将用户的优惠券进行核销，该过程不可逆
        /// </summary>
        public WxApiConsumeCodeRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID。创建卡券时use_custom_code填写true时必填。非自定义Code不必填写。
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 需核销的Code码。
        /// </summary>
        public string Code { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/code/consume";
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
                { "code",Code }
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
