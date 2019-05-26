using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// StockQuantity Data Structure.
    /// </summary>
    [Serializable]
    public class StockQuantity : AliApiObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
