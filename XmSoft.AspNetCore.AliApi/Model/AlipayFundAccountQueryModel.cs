using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFundAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountQueryModel : AliApiObject
    {
        /// <summary>
        /// 开户产品码。如果查询托管子户余额，必传且必须传入与开户时传入的值一致。
        /// </summary>
        [XmlElement("account_product_code")]
        public string AccountProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户会员的唯一标识。如果传入的user_id为虚拟账户userId，此字段必传并比对一致性。
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
