using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherStatusQueryModel : AliApiObject
    {
        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
