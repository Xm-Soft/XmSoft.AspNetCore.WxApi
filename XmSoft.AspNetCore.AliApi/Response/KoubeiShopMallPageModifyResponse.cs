using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiShopMallPageModifyResponse.
    /// </summary>
    public class KoubeiShopMallPageModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 工单id（用以查询创建，修改操作的审核状态）
        /// </summary>
        [XmlElement("order_flow_id")]
        public string OrderFlowId { get; set; }
    }
}
