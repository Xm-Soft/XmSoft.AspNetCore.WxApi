using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundworkCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [XmlElement("inbound_work_id")]
        public string InboundWorkId { get; set; }
    }
}
