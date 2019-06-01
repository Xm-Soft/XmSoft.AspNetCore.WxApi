using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 设置买单接口
    /// </summary>
    public class WxApiSetPayCellRequest : IWxApiRequest<WxApiSetPayCellResponse>
    {

        /// <summary>
        /// 设置买单接口 -- 公众平台
        /// <para>1.设置快速买单的卡券须支持至少一家有核销员门店，否则无法设置成功；</para>
        ///<para>2.若该卡券设置了center_url（居中使用跳转链接）,须先将该设置更新为空后再设置自快速买单方可生效。</para>
        /// </summary>
        public WxApiSetPayCellRequest()
        {
           
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


        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/paycell/set";
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
                { "is_open",Is_open }
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
