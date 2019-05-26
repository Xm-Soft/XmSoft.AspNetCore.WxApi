using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthSpaccountQueryModel : AliApiObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
