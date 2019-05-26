using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsSupplierQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsSupplierQueryModel : AliApiObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 供应商ID，限制批量查询100个ID
        /// </summary>
        [XmlArray("supplier_ids")]
        [XmlArrayItem("string")]
        public List<string> SupplierIds { get; set; }
    }
}
