using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppFlowModeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowModeQueryModel : AliApiObject
    {
        /// <summary>
        /// json扩展字段
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
