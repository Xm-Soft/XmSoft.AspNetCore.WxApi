using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Poi;

namespace XmSoft.AspNetCore.WxApi.Request.Poi
{
    /// <summary>
    /// 获取门店信息
    /// </summary>
    public class WxApiGetPoiRequest : IWxApiRequest<WxApiGetPoiResponse>
    {
        /// <summary>
        /// 获取门店信息 -- 公众平台
        /// </summary>
        public WxApiGetPoiRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 创建门店信息
        /// </summary>
        public Poi Buffer { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "http://api.weixin.qq.com/cgi-bin/poi/getpoi";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "buffer",Buffer == null ? null:JsonConvert.SerializeObject(Buffer) }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    public class  Poi
    {
        /// <summary>
        /// 门店Id
        /// </summary>
        public string poi_id { get; set; }
    }
}
