using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.NearbyPoi;

namespace XmSoft.AspNetCore.WxApi.Request.NearbyPoi
{
    /// <summary>
    ///展示/取消展示附近小程序
    /// </summary>
    public class WxApiSetShowStatusNearbyPoiRequest : IWxApiRequest<WxApiSetShowStatusNearbyPoiResponse>
    {
        /// <summary>
        /// 展示/取消展示附近小程序
        /// </summary>
        public WxApiSetShowStatusNearbyPoiRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 附近地点 ID
        /// </summary>
        public string Poi_id { get; set; }
        /// <summary>
        /// 是否展示 0	不展示, 1	展示
        /// </summary>
        public int Status { get; set; }



        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/setnearbypoishowstatus";
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
                { "poi_id", Poi_id },
                {"status",Status }
            };
            return parameters;
        }

        #endregion
    }
}
