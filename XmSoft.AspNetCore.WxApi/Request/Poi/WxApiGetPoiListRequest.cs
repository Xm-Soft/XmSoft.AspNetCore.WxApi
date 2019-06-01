using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Poi;

namespace XmSoft.AspNetCore.WxApi.Request.Poi
{
    /// <summary>
    /// 查询门店列表信息
    /// </summary>
    public class WxApiGetPoiListRequest : IWxApiRequest<WxApiGetPoiListResponse>
    {
        /// <summary>
        /// 查询门店列表信息 -- 公众平台
        /// </summary>
        public WxApiGetPoiListRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 创建门店信息
        /// </summary>
        public QueryPoi Buffer { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/poi/getpoilist";
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
    public class  QueryPoi
    {
        /// <summary>
        /// 开始位置，0 即为从第一条开始查询
        /// </summary>
        public int begin { get; set; }
        /// <summary>
        /// 返回数据条数，最大允许50，默认为20
        /// </summary>
        public int limit { get; set; }
    }
}
