using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsSceneProductAgreementCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductAgreementCancelModel : AliApiObject
    {
        /// <summary>
        /// 签订协议商户支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 产品协议号
        /// </summary>
        [XmlElement("product_sign_no")]
        public string ProductSignNo { get; set; }
    }
}
