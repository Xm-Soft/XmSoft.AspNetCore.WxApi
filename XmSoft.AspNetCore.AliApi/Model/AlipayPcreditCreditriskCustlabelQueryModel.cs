using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditriskCustlabelQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝2088id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
