using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetproduceAssignSyncModel : AliApiObject
    {
        /// <summary>
        /// 生产指令接收情况，最多200条
        /// </summary>
        [XmlArray("asset_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> AssetResults { get; set; }
    }
}