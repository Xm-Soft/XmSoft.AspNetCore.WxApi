using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserNewbenefitCreateResponse.
    /// </summary>
    public class AlipayUserNewbenefitCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 权益的ID，可以根据此ID对权益进行操作
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
