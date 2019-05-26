using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBossFncInvoicereceiptBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicereceiptBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 月账单号集合，唯一性ID集合，月账单表唯一主键ID集合
        /// </summary>
        [XmlArray("bill_nos")]
        [XmlArrayItem("string")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 来源类型，01：主站；02：芝麻；03：金融云；04：微贷
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
