using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 拉取卡券概况数据接口
    /// </summary>
    public class WxApiGetCardBizuinInfoRequest : IWxApiRequest<WxApiGetCardBizuinInfoResponse>
    {

        /// <summary>
        /// 拉取卡券概况数据接口 -- 公众平台
        /// 支持调用该接口拉取本商户的总体数据情况，包括时间区间内的各指标总量。
        /// </summary>
        public WxApiGetCardBizuinInfoRequest()
        {
           
        }
        public string AccessToken { get; set; }

        /// <summary>
        /// 查询数据的起始时间。
        /// </summary>
        public string Begin_date { get; set; }
        /// <summary>
        /// 查询数据的截至时间。
        /// </summary>
        public string End_date { get; set; }
        /// <summary>
        /// 页面的title。
        /// </summary>
        public int Cond_source { get; set; }
        

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/datacube/getcardbizuininfo";
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
                { "cond_source", Cond_source}
               
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
