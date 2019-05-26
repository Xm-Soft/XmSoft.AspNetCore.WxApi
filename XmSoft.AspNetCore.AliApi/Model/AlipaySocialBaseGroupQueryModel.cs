using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySocialBaseGroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseGroupQueryModel : AliApiObject
    {
        /// <summary>
        /// 群的id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
