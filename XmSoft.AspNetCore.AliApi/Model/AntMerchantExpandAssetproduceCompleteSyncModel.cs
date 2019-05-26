using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetproduceCompleteSyncModel : AliApiObject
    {
        /// <summary>
        /// 物料生产单完成后指定物流信息
        /// </summary>
        [XmlArray("asset_produce_details")]
        [XmlArrayItem("item_delivery_detail")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
