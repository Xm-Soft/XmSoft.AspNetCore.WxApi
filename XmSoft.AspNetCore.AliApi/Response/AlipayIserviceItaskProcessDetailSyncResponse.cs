using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [XmlElement("alipay_process_id")]
        public string AlipayProcessId { get; set; }
    }
}
