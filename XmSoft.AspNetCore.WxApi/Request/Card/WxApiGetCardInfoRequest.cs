using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///查看卡券详情
    /// </summary>
    public class WxApiGetCardInfoRequest : IWxApiRequest<WxApiGetCardInfoResponse>
    {

        /// <summary>
        ///查看卡券详情 公众平台
        ///开发者可以调用该接口查询某个card_id的创建信息、审核状态以及库存数量。
        /// </summary>
        public WxApiGetCardInfoRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID。创建卡券时use_custom_code填写true时必填。非自定义Code不必填写。
        /// </summary>
        public string Card_id { get; set; }
       

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/get";
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
                { "card_id",Card_id }
               
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
