using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ContactModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContactModel : AliApiObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
