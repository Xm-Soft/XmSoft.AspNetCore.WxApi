using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 获取用户访问小程序数据月趋势
    /// </summary>
    public class WxApiGetMonthlyVisitTrendRequest : IWxApiRequest<WxApiGetMonthlyVisitTrendResponse>
    {
        /// <summary>
        /// 获取用户访问小程序数据月趋势
        /// </summary>
        public WxApiGetMonthlyVisitTrendRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 开始日期。格式为 yyyymmdd
        /// </summary>
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，限定查询1天数据，允许设置的最大值为昨日。格式为 yyyymmdd
        /// </summary>
        public string EndDate { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/datacube/getweanalysisappidmonthlyvisittrend";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "begin_date", BeginDate },
                { "end_date", EndDate }
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
}
