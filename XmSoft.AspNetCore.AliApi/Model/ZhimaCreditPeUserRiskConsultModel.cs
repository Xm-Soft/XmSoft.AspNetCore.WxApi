using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeUserRiskConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserRiskConsultModel : AliApiObject
    {
        /// <summary>
        /// 业务action，由芝麻信用分配，目前只能取值：level_600 或者 level_650，分别对应芝麻分600分和650分的准入门槛。后续可能会有更多种取值选择，届时请联系技术支持
        /// </summary>
        [XmlElement("biz_action")]
        public string BizAction { get; set; }

        /// <summary>
        /// 类目code，由芝麻信用分配，目前只能取值：SHARABLE_BICYCLE。后续可能会有多种取值选择，届时请联系技术支持
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 信用场景码，由芝麻信用分配，目前只能取值：credit_evaluate_mini。后续可能会有多种取值选择，届时请联系技术支持
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 业务相关扩展参数，该参数格式是 Map 序列化之后的json字符串，Map中的key请联系技术支持给定。该参数可根据具体需求选填，没有请不填。
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 商户订单号或者流水号，用以标明商户的一次评估调用，可以用来对账等。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，固定值: w1010100001000002428
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 准入风险评估需要的环境参数，比如用户的ip地址，mac地址等。该参数格式是 Map序列化之后的json字符串，Map中的key请联系技术支持给定。该参数可根据具体需求选填，没有请不填。
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }
    }
}
