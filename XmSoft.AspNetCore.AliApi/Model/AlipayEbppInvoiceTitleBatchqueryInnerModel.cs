using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryInnerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleBatchqueryInnerModel : AliApiObject
    {
        /// <summary>
        /// 抬头所属支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
