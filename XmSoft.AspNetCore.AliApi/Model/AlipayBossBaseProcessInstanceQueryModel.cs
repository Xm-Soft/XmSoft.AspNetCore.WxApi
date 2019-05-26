using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceQueryModel : AliApiObject
    {
        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
