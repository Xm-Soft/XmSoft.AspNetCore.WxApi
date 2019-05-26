using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiQualityTestCloudacptBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestCloudacptBatchQueryModel : AliApiObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// partener id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
