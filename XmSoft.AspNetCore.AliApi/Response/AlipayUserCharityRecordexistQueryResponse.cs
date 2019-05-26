using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCharityRecordexistQueryResponse.
    /// </summary>
    public class AlipayUserCharityRecordexistQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否有过捐赠记录(有:true,否:false)
        /// </summary>
        [XmlElement("donation_tag")]
        public bool DonationTag { get; set; }
    }
}
