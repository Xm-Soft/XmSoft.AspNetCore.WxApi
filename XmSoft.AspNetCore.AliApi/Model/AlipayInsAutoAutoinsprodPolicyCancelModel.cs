using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodPolicyCancelModel : AliApiObject
    {
        /// <summary>
        /// 车险订单号
        /// </summary>
        [XmlElement("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
