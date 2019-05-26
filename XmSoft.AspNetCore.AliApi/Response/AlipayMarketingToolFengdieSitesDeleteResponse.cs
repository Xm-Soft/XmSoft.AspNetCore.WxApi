using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesDeleteResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 返回删除云凤蝶站点成功与失败的结果
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
