using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppJfexportChargeinstQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportChargeinstQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 输出的机构列表
        /// </summary>
        [XmlArray("charge_insts")]
        [XmlArrayItem("jf_export_charge_inst_model")]
        public List<JfExportChargeInstModel> ChargeInsts { get; set; }

        /// <summary>
        /// 开通的出账机构总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
