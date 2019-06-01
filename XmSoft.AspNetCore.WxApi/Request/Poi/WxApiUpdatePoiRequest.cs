using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Poi;

namespace XmSoft.AspNetCore.WxApi.Request.Poi
{
    /// <summary>
    /// 修改门店信息
    /// </summary>
    public class WxApiUpdatePoiRequest : IWxApiRequest<WxApiAddPoiResponse>
    {
        /// <summary>
        /// 修改门店信息 -- 公众平台
        /// </summary>
        public WxApiUpdatePoiRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 创建门店信息
        /// </summary>
        public Business Buffer { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/poi/updatepoi";
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
   
}
