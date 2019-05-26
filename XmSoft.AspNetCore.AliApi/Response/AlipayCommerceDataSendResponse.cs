using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceDataSendResponse.
    /// </summary>
    public class AlipayCommerceDataSendResponse : AliApiResponse
    {
        /// <summary>
        /// data_send_business_result:数据发送业务处理结果信息
        /// </summary>
        [XmlElement("data_send_business_result")]
        public DataSendBusinessResult DataSendBusinessResult { get; set; }
    }
}
