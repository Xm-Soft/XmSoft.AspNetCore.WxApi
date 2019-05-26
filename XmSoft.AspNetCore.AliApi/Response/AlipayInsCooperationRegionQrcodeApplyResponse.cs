using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsCooperationRegionQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationRegionQrcodeApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
