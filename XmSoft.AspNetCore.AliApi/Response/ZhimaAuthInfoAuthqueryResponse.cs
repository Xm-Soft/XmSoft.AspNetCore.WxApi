using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaAuthInfoAuthqueryResponse.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否已经授权； authorized＝true 表示已授权, authorized＝false表示未授权
        /// </summary>
        [XmlElement("authorized")]
        public bool Authorized { get; set; }

        /// <summary>
        /// 当前授权业务查询标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
