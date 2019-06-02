using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///获取用户已领取卡券接口
    /// </summary>
    public class WxApiGetCardListByUserRequest : IWxApiRequest<WxApiGetCardListByUserResponse>
    {

        /// <summary>
        ///获取用户已领取卡券接口 公众平台
        ///用于获取用户卡包里的，属于该appid下所有可用卡券，包括正常状态和异常状态。
        /// </summary>
        public WxApiGetCardListByUserRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID。不填写时默认查询当前appid下的卡券。
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 需要查询的用户openid
        /// </summary>
        public string Openid { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/user/getcardlist";
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
                { "openid",Openid }
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
