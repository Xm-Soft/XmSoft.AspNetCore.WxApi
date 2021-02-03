using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///修改库存接口口
    /// </summary>
    public class WxApiModifyStockRequest : IWxApiRequest<WxApiModifyStockResponse>
    {

        /// <summary>
        ///修改库存接口 公众平台
        /// </summary>
        public WxApiModifyStockRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 增加多少库存，支持不填或填0。
        /// </summary>
        public int Increase_stock_value { get; set; }
        /// <summary>
        ///减少多少库存，可以不填或填0。
        /// </summary>
        public int Reduce_stock_value { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/modifystock";
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

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "card_id",Card_id },
                { "increase_stock_value",Increase_stock_value },
                { "reduce_stock_value",Reduce_stock_value }
            };
            return parameters;
        }

        #endregion
    }
}
