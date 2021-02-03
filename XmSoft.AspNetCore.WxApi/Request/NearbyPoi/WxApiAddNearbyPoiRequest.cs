using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.NearbyPoi;

namespace XmSoft.AspNetCore.WxApi.Request.NearbyPoi
{
    /// <summary>
    ///添加地点
    /// </summary>
    public class WxApiAddNearbyPoiRequest : IWxApiRequest<WxApiAddNearbyPoiResponse>
    {
        /// <summary>
        /// 添加地点
        /// </summary>
        public WxApiAddNearbyPoiRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 经营资质主体，必填
        /// </summary>
        public string Related_name { get; set; }
        /// <summary>
        /// 经营资质证件号，必填
        /// </summary>
        public string Related_credential { get; set; }
        /// <summary>
        /// 经营资质地址，必填   
        /// </summary>
        public string Related_address { get; set; }
        /// <summary>
        /// 相关证明材料照片临时素材 mediaid。经营资质主体与小程序同主体时不填;经营资质主体与小程序非同主体时必填。
        /// 可通过 customerServiceMessage.uploadTempMedia 接口上传照片临时素材。
        /// </summary>
        public string Related_proof_material { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/addnearbypoi";
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
                { "related_name", Related_name },
                { "related_address", Related_address },
                { "related_credential", Related_credential },
                { "related_proof_material", Related_proof_material }
            };
            return parameters;
        }

        #endregion
    }
}
