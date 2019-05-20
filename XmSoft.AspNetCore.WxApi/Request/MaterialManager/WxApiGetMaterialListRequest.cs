using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 获取素材列表
    /// </summary>
    public class WxApiGetMaterialListRequest : IWxApiRequest<WxApiGetMaterialListResponse>
    {
        /// <summary>
        ///获取素材列表 - 公众平台
        /// </summary>
        public WxApiGetMaterialListRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 	素材的类型，图片（image）、视频（video）、语音 （voice）、图文（news）
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 从全部素材的该偏移位置开始返回，0表示从第一个素材 返回
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 返回素材的数量，取值在1到20之间
        /// </summary>
        public int Count { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/batchget_material";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                {"type", Type},
                {"offset", Offset},
                {"count", Count},

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
