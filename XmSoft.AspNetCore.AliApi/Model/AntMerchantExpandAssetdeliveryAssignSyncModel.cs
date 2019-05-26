using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetdeliveryAssignSyncModel : AliApiObject
    {
        /// <summary>
        /// 配送指令接收反馈，最多200条
        /// </summary>
        [XmlArray("delivery_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
