using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CraftsmanSubAssessment Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanSubAssessment : AliApiObject
    {
        /// <summary>
        /// 子评分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 子评分项名
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
