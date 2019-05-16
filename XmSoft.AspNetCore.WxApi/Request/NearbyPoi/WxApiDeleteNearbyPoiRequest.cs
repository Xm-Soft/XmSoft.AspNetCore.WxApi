using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.NearbyPoi;

namespace XmSoft.AspNetCore.WxApi.Request.NearbyPoi
{
    /// <summary>
    ///删除地点
    /// </summary>
    public class WxApiDeleteNearbyPoiRequest : IWxApiRequest<WxApiDeleteNearbyPoiResponse>
    {
        /// <summary>
        /// 删除地点
        /// </summary>
        public WxApiDeleteNearbyPoiRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 附近地点 ID
        /// </summary>
        public string Poi_id { get; set; }
       


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/delnearbypoi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "poi_id", Poi_id }
            
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
