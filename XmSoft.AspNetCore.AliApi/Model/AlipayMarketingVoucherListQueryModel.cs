using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingVoucherListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherListQueryModel : AliApiObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
