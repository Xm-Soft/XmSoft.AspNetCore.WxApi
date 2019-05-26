using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class ComplextMockModel : AliApiObject
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [XmlElement("biz_model")]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// 208xxx
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
