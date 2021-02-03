using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.DataAnalysis;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 获取累计用户数据
    /// </summary>
    public class WxApiGetUserCumulateRequest : IWxApiRequest<WxApiGetUserCumulateResponse>
    {
        /// <summary>
        ///  获取累计用户数据 - 公众平台
        /// </summary>
        public WxApiGetUserCumulateRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 开始日期。格式为 yyyy-mm-dd
        /// </summary>
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd
        /// </summary>
        public string EndDate { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/datacube/getusercumulate";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "begin_date", BeginDate },
                { "end_date", EndDate }
            };
            return parameters;
        }

        #endregion
    }
}
