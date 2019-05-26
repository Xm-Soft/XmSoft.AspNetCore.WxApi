using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// TableInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class TableInfoResult : AliApiObject
    {
        /// <summary>
        /// 返回TableListResult集合
        /// </summary>
        [XmlArray("table_info_list")]
        [XmlArrayItem("table_list_result")]
        public List<TableListResult> TableInfoList { get; set; }
    }
}
