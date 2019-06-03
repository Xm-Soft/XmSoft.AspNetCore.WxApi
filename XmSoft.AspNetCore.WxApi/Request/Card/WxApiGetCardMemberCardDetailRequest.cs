using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 拉取单张会员卡数据接口
    /// </summary>
    public class WxApiGetCardMemberCardDetailRequest : IWxApiRequest<WxApiGetCardMemberCardDetailResponse>
    {

        /// <summary>
        /// 拉取单张会员卡数据接口 -- 公众平台
        /// 支持开发者调用该接口拉取API创建的会员卡数据情况
        /// </summary>
        public WxApiGetCardMemberCardDetailRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string Card_id { get; set; }
        /// <summary>
        /// 查询数据的起始时间。
        /// </summary>
        public string Begin_date { get; set; }
        /// <summary>
        /// 查询数据的截至时间。
        /// </summary>
        public string End_date { get; set; }
       
        

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/datacube/getcardmembercarddetail";
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
                { "begin_date", Begin_date},
                { "end_date",End_date },
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
