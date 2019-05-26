using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendResponse : AliApiResponse
    {
        /// <summary>
        /// 分配模板的操作是否成功
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
