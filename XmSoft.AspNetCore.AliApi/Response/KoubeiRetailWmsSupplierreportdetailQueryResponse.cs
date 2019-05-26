using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportdetailQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 盘点单信息
        /// </summary>
        [XmlElement("supplier_report")]
        public SupplierReport SupplierReport { get; set; }

        /// <summary>
        /// 盘点单明细记录
        /// </summary>
        [XmlArray("supplier_report_details")]
        [XmlArrayItem("supplier_report_detail")]
        public List<SupplierReportDetail> SupplierReportDetails { get; set; }
    }
}
