using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillDeleteResponse.
    /// </summary>
    public class AlipayEcoCplifeBillDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 不允许删除（支付中或者支付完成）的账单明细条目列表
        /// </summary>
        [XmlArray("alive_bill_entry_list")]
        [XmlArrayItem("c_p_alive_bill_entry_set")]
        public List<CPAliveBillEntrySet> AliveBillEntryList { get; set; }
    }
}
