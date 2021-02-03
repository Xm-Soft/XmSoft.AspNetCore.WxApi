using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request
{
    /// <summary>
    /// 获取小程序新增或活跃用户的画像分布数据。时间范围支持昨天、最近7天、最近30天。
    /// 其中，新增用户数为时间范围内首次访问小程序的去重用户数，活跃用户数为时间范围内访问过小程序的去重用户数
    /// </summary>
    public class WxApiGetUserPortraitRequest : IWxApiRequest<WxApiGetUserPortraitResponse>
    {
        /// <summary>
        /// 获取小程序新增或活跃用户的画像分布数据。时间范围支持昨天、最近7天、最近30天。
        /// <para>其中，新增用户数为时间范围内首次访问小程序的去重用户数，活跃用户数为时间范围内访问过小程序的去重用户数</para>
        /// </summary>
        public WxApiGetUserPortraitRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 开始日期。格式为 yyyymmdd
        /// </summary>
        public string BeginDate { get; set; }
        /// <summary>
        /// 结束日期，开始日期与结束日期相差的天数限定为0/6/29，分别表示查询最近1/7/30天数据，允许设置的最大值为昨日。格式为 yyyymmdd
        /// </summary>
        public string EndDate { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/datacube/getweanalysisappiduserportrait";
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
