using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGnameModifyModel : AliApiObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
