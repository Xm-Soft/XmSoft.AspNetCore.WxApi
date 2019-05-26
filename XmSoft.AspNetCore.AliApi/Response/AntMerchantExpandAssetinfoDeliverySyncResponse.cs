using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoDeliverySyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoDeliverySyncResponse : AliApiResponse
    {
        /// <summary>
        /// 物料信息反馈处理结果
        /// </summary>
        [XmlArray("info_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
