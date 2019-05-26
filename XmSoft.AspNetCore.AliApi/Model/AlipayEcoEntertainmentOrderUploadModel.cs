using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoEntertainmentOrderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEntertainmentOrderUploadModel : AliApiObject
    {
        /// <summary>
        /// 数娱充值ISV订单回流模型
        /// </summary>
        [XmlElement("entertainment_order_info")]
        public EntertainmentOrderInfo EntertainmentOrderInfo { get; set; }
    }
}
