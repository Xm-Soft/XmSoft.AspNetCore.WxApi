using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 用户支付完成后，获取该用户的 UnionId，无需用户授权
    /// </summary>
    public class WxApiGetPaidUnionidRequest : IWxApiRequest<WxApiGetPaidUnionidResponse>
    {
        /// <summary>
        /// 用户支付完成后，获取该用户的 UnionId，无需用户授权 小程序
        /// <para>调用前需要用户完成支付，且在支付后的五分钟内有效。</para>
        /// </summary>
        public WxApiGetPaidUnionidRequest()
        {
            
        }
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 支付用户唯一标识
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 	微信支付订单号  非必填
        /// </summary>
        public string Transaction_id { get; set; }
        /// <summary>
        /// 微信支付分配的商户号，和商户订单号配合使用 非必填
        /// </summary>
        public string Mch_id { get; set; }
        /// <summary>
        /// 微信支付商户订单号，和商户号配合使用 非必填
        /// </summary>
        public string OutTradeNo { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/getpaidunionid";
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
                { "openid", Openid },
                { "transaction_id", Transaction_id },
                { "mch_id", Mch_id },
                { "out_trade_no", OutTradeNo }
            };
            return parameters;
        }

        /// <summary>
        /// 请求方式 Post Or Get
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
