using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    ///批量查询卡券列表
    /// </summary>
    public class WxApiBatchGetCardListRequest : IWxApiRequest<WxApiBatchGetCardListResponse>
    {

        /// <summary>
        ///批量查询卡券列表 公众平台
        /// </summary>
        public WxApiBatchGetCardListRequest()
        {
           
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 查询卡列表的起始偏移量，从0开始，即offset: 5是指从从列表里的第六个开始读取。
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 需要查询的卡片的数量（数量最大50）。
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 支持开发者拉出指定状态的卡券列表 “CARD_STATUS_NOT_VERIFY”, 待审核 ； “CARD_STATUS_VERIFY_FAIL”, 
        /// <para>审核失败； “CARD_STATUS_VERIFY_OK”， 通过审核； “CARD_STATUS_DELETE”， </para>
        /// <para>卡券被商户删除； “CARD_STATUS_DISPATCH”， 在公众平台投放过的卡券；</para>
        /// </summary>
        public string[] Status_list { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/batchget";
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
                { "offset",Offset },
                { "count",Count }
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
