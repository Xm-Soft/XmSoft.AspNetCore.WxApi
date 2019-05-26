using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserCustIdentifyActivity Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCustIdentifyActivity : AliApiObject
    {
        /// <summary>
        /// 活动扩展信息，预留字段。例如通过连接引导参加运营活动，包含活动链接（或者参与方式）及活动信息。
        /// </summary>
        [XmlElement("activity_info")]
        public string ActivityInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }
    }
}
