using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityInfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommunityInfoSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [XmlElement("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 小区同步状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
