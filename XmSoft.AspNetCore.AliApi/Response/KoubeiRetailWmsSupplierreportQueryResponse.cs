using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 盘点单列表
        /// </summary>
        [XmlArray("supplier_report_list")]
        [XmlArrayItem("supplier_report")]
        public List<SupplierReport> SupplierReportList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
