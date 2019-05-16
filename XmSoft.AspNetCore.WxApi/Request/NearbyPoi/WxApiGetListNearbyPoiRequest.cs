using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.NearbyPoi;

namespace XmSoft.AspNetCore.WxApi.Request.NearbyPoi
{
    /// <summary>
    ///查看地点列表
    /// </summary>
    public class WxApiGetListNearbyPoiRequest : IWxApiRequest<WxApiGetListNearbyPoiResponse>
    {
        /// <summary>
        /// 查看地点列表
        /// </summary>
        public WxApiGetListNearbyPoiRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 起始页id（从1开始计数）
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 每页展示个数（最多1000个）
        /// </summary>
        public int Page_rows { get; set; }



        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/getnearbypoilist";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "page", Page },
                {"page_rows",Page_rows }
            
            };
            return parameters;
        }

        public bool IsPost()
        {
            return false;
        }

        #endregion
    }
}
