using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelCreateModel : AliApiObject
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
