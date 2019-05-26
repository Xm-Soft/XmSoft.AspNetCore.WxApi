using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherQueryModel : AliApiObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
