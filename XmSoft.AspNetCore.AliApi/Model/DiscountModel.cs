using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// DiscountModel Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountModel : AliApiObject
    {
        /// <summary>
        /// 每期折扣，保留小数点2位
        /// </summary>
        [XmlElement("term_discount")]
        public string TermDiscount { get; set; }

        /// <summary>
        /// 分期期次，0表示不分期，整笔折扣
        /// </summary>
        [XmlElement("term_no")]
        public long TermNo { get; set; }
    }
}
