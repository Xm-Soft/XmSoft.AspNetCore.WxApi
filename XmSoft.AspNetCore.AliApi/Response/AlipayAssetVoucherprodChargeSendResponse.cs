using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAssetVoucherprodChargeSendResponse.
    /// </summary>
    public class AlipayAssetVoucherprodChargeSendResponse : AliApiResponse
    {
        /// <summary>
        /// 资产id编号
        /// </summary>
        [XmlElement("asset_instance_id")]
        public string AssetInstanceId { get; set; }

        /// <summary>
        /// 支付宝充值订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
