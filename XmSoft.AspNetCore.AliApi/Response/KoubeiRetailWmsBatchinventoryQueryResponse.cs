using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsBatchinventoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsBatchinventoryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 库存信息列表
        /// </summary>
        [XmlArray("inventory_list")]
        [XmlArrayItem("inventory")]
        public List<Inventory> InventoryList { get; set; }
    }
}
