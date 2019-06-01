using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 设置自助核销接口
    /// </summary>
    public class WxApiSelfconsumeCellRequest : IWxApiRequest<WxApiSelfconsumeCellResponse>
    {

        /// <summary>
        ///设置自助核销接口 -- 公众平台
        /// <para>创建卡券之后，开发者可以通过设置微信买单接口设置该card_id支持自助核销功能。</para>
        ///<para>值得开发者注意的是，设置自助核销的card_id必须已经配置了门店，否则会报错</para>
        /// </summary>
        public WxApiSelfconsumeCellRequest()
        {
            Need_verify_cod = false;
            Need_remark_amount = false;

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 	卡券ID。
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 是否开启买单功能，填true/false
        /// </summary>
        public bool Is_open { get; set; }
        /// <summary>
        /// 用户核销时是否需要输入验证码， 填true/false， 默认为false
        /// </summary>
        public bool Need_verify_cod { get; set; }
        /// <summary>
        /// 用户核销时是否需要备注核销金额， 填true/false， 默认为false
        /// </summary>
        public bool Need_remark_amount { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/selfconsumecell/set";
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
                { "is_open",Is_open },
                { "need_verify_cod",Need_verify_cod },
                { "need_remark_amount",Need_remark_amount }
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
