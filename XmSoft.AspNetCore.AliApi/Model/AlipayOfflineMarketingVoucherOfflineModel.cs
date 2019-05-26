using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherOfflineModel : AliApiObject
    {
        /// <summary>
        /// 下架描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板编号
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
