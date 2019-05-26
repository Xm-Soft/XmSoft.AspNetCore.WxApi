using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInfoApplyidQueryModel : AliApiObject
    {
        /// <summary>
        /// 申请开票时支付宝返回的申请id，具有全局唯一性。
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
