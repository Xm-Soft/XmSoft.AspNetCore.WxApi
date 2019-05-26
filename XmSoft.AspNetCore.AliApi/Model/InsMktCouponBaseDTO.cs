using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InsMktCouponBaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponBaseDTO : AliApiObject
    {
        /// <summary>
        /// 权益Id
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }
    }
}
