using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryCompleteSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 配送反馈处理结果
        /// </summary>
        [XmlArray("delivery_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
