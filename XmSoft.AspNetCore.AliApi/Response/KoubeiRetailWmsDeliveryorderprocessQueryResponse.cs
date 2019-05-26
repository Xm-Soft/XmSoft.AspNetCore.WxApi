using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliveryorderprocessQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 物流单据状态列表
        /// </summary>
        [XmlArray("delivery_order_process_vo_list")]
        [XmlArrayItem("delivery_order_process_v_o")]
        public List<DeliveryOrderProcessVO> DeliveryOrderProcessVoList { get; set; }
    }
}
