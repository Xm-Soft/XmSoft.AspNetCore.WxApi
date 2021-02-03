using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///查询Code接口
    /// </summary>
    public class WxApiGetCodeRequest : IWxApiRequest<WxApiGetCodeResponse>
    {

        /// <summary>
        ///查询Code接口-- 核销卡券 公众平台
        /// </summary>
        public WxApiGetCodeRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID代表一类卡券。自定义code卡券必填。
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 	是否校验code核销状态，填入true和false时的code异常状态返回数据不同。
        /// </summary>
        public string Check_consume { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/code/get";
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
                { "check_consume",Check_consume }
            };
            return parameters;
        }

        #endregion
    }
}
