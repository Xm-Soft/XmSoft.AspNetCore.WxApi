using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskWidgetQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
