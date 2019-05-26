using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppIndustryBillNettingRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBillNettingRefundModel : AliApiObject
    {
        /// <summary>
        /// 支付宝流水号。
        /// </summary>
        [XmlElement("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 扩展字段，一系列键值对属性列表，示例只是个形式，具体的Key-Value需要根据具体业务另行约定。  无特别约定时，此字段不必传。
        /// </summary>
        [XmlArray("industry_extend_field_list")]
        [XmlArrayItem("industry_extend_field")]
        public List<IndustryExtendField> IndustryExtendFieldList { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退款金额，单位：元  不可超过创单时的金额。  如果scene是TOTAL_FAILURE，则强制要求全额轧差退款，不支持部分轧差退款。
        /// </summary>
        [XmlElement("netting_amount")]
        public string NettingAmount { get; set; }

        /// <summary>
        /// 退款场景，不同场景由不同策略处理。  PARTIALLY_DONE：业务上部分失败导致轧差退款  TOTAL_FAILURE：完全失败导致的轧差退款
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
