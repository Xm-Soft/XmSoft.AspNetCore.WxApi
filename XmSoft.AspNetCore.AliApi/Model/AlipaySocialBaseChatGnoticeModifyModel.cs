using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGnoticeModifyModel : AliApiObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("group_notice")]
        public string GroupNotice { get; set; }
    }
}
