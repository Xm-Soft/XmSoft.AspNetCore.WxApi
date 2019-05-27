using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Express;

namespace XmSoft.AspNetCore.WxApi.Request.Express
{
    /// <summary>
    /// 查询运单轨迹
    /// </summary>
    public class WxApiGetBusinessPathRequest : IWxApiRequest<WxApiGetBusinessPathResponse>
    {
        /// <summary>
        /// 查询运单轨迹
        /// </summary>
        public WxApiGetBusinessPathRequest()
        {
            
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 订单 ID，需保证全局唯一
        /// </summary>

        public string Order_id { get; set; }
        /// <summary>
        ///用户 openid
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 快递公司ID，参见getAllDelivery
        /// </summary>
        public string Delivery_id { get; set; }

        /// <summary>
        /// 运单ID
        /// </summary>
        public string Waybill_id { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/express/business/path/get";
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
                { "order_id", Order_id },
                { "openid", Openid },
                { "delivery_id", Delivery_id },
                {"waybill_id",Waybill_id }
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
