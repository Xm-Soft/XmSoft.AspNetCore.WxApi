using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsSupplierreportdetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [XmlElement("supplier_report_id")]
        public string SupplierReportId { get; set; }
    }
}
