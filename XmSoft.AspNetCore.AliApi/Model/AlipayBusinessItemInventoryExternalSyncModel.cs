using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBusinessItemInventoryExternalSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessItemInventoryExternalSyncModel : AliApiObject
    {
        /// <summary>
        /// 商品库存信息列表
        /// </summary>
        [XmlArray("inventories")]
        [XmlArrayItem("item_inventory")]
        public List<ItemInventory> Inventories { get; set; }

        /// <summary>
        /// 请求ID，支持英文字母和数字，由调用者自行定义（不允许重复）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
