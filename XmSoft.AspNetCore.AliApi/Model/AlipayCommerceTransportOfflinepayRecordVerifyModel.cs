using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AliApiObject
    {
        /// <summary>
        /// 原始脱机记录信息
        /// </summary>
        [XmlElement("record")]
        public string Record { get; set; }
    }
}
