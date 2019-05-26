using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayTradePaygrowthPayabilityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePaygrowthPayabilityQueryModel : AliApiObject
    {
        /// <summary>
        /// 业务标识，用于支付场景，需要根据具体的支付类型传值。
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 实际支付金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 请求来源，必传，新的场景取值需要根据业务定义。
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 支付宝userId，不能为空
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
