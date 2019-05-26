using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AnswerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerModel : AliApiObject
    {
        /// <summary>
        /// 供填空和问卷内容提交的附加项
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 问题id信息
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 选项id
        /// </summary>
        [XmlElement("option_id")]
        public long OptionId { get; set; }
    }
}
