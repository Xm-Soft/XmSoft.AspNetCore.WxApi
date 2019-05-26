using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetdeliveryCompleteSyncModel : AliApiObject
    {
        /// <summary>
        /// 配送完成反馈信息
        /// </summary>
        [XmlArray("asset_delivery_details")]
        [XmlArrayItem("asset_delivery_detail")]
        public List<AssetDeliveryDetail> AssetDeliveryDetails { get; set; }
    }
}
