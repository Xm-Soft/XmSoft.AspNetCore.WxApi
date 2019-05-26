using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserLabelDeleteModel : AliApiObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [XmlArray("matchers")]
        [XmlArrayItem("matcher")]
        public List<Matcher> Matchers { get; set; }
    }
}
