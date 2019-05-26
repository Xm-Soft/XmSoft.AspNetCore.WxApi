using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [XmlElement("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
