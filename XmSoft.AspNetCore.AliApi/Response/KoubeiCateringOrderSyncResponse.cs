using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringOrderSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
