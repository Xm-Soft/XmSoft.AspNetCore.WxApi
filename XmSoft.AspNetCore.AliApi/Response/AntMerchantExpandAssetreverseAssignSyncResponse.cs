using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetreverseAssignSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，处理结果
        /// </summary>
        [XmlArray("delivery_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
