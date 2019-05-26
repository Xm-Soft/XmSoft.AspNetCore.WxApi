using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayVirtualcardBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayVirtualcardBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 虚拟卡信息查询结果列表
        /// </summary>
        [XmlArray("card_models")]
        [XmlArrayItem("alipay_query_card_model_result")]
        public List<AlipayQueryCardModelResult> CardModels { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("sub_error_code")]
        public string SubErrorCode { get; set; }
    }
}
