using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAgentCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
