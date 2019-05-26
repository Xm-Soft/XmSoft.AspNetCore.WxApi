using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AliApiObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [XmlArray("goods_safety_inventorys")]
        [XmlArrayItem("goods_safety_inventory")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
