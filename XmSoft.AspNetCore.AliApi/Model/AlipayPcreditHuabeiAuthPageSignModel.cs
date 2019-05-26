using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthPageSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAuthPageSignModel : AliApiObject
    {
        /// <summary>
        /// 花呗先享签约场景，商户和支付宝签约时确定，商户可咨询技术支持。目前暂定为淘宝(TB_PCARD)和外部商户(EXTERNAL_PCARD)两大类。
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 签约过程中期望进行花呗初始冻结的金额，单位为元，精确到小数点后两位。
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。支付宝侧用来做花呗冻结请求的幂等。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部签约号，由商户提供，花呗先享协议中标示用户的唯一签约号（确保在商户系统中唯一）。  商户与支付宝签约时确认具体的格式规则。  商户系统按需传入，支付宝用做先享协议级别幂等，即同一用户在同一商户、同一花呗先享签约场景下是否唯一。  长度不能超过64位
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
