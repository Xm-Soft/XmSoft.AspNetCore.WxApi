using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeLabelDeleteModel : AliApiObject
    {
        /// <summary>
        /// 标签id, 只支持生活号自定义标签
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }
    }
}
