using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleDynamicGetModel : AliApiObject
    {
        /// <summary>
        /// 抬头动态码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }
    }
}
