using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelDeleteModel : AliApiObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
