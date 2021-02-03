using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 修改永久图文素材
    /// </summary>
    public class WxApiUpdateForeverNewsRequest : IWxApiRequest<WxApiUpdateForeverNewsResponse>
    {
        /// <summary>
        ///修改永久图文素材 - 公众平台
        /// </summary>
        public WxApiUpdateForeverNewsRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 素材ID
        /// </summary>
        public string Media_id { get; set; }
       
        public string Index { get; set; }

        public Articles Articles { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/update_news";
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
                { "media_id", Media_id },
                { "index", Index },
                { "articles", Articles == null ? null :JsonConvert.SerializeObject(Articles) }
            };
            return parameters;
        }

        #endregion
    }
    

}
