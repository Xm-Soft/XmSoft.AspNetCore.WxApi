using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTemplateQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝卡模板ID（模板创建接口返回的支付宝端模板ID）
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
