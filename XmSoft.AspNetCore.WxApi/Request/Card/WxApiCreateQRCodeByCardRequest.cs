using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 卡券-创建二维码接口
    /// </summary>
    public class WxApiCreateQRCodeByCardRequest : IWxApiRequest<WxApiCreateQRCodeByCardResponse>
    {
        private JsonSerializerSettings settings;
        /// <summary>
        /// 卡券-创建二维码接口 -- 公众平台
        /// </summary>
        public WxApiCreateQRCodeByCardRequest()
        {
            settings = new JsonSerializerSettings();
            //过滤掉空值的属性
            settings.NullValueHandling = NullValueHandling.Ignore;
            
        }
        public string AccessToken { get; set; }
       
        public string Action_name { get; set; }

        public int Expire_seconds { get; set; }

        public ActionInfo Action_info { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/qrcode/create";
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
                { "action_name",Action_name },
                { "expire_seconds", Expire_seconds},
                
                { "action_info", Action_info == null ? null: JsonConvert.SerializeObject(Action_info,settings) }
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
