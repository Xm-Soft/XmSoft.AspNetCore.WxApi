using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataDeerConnectorQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDeerConnectorQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回活动的流量数据
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 请求业务处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
