using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PartnerVO Data Structure.
    /// </summary>
    [Serializable]
    public class PartnerVO : AliApiObject
    {
        /// <summary>
        /// 生效状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 商户简码
        /// </summary>
        [XmlElement("short_code")]
        public string ShortCode { get; set; }
    }
}
