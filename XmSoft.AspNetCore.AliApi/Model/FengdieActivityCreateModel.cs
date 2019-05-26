using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FengdieActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityCreateModel : AliApiObject
    {
        /// <summary>
        /// 云凤蝶站点的 id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
