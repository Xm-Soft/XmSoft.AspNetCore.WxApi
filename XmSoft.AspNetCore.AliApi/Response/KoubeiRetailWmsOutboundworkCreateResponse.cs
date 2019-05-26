using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundworkCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 出库作业id
        /// </summary>
        [XmlElement("outbound_work_id")]
        public string OutboundWorkId { get; set; }
    }
}
