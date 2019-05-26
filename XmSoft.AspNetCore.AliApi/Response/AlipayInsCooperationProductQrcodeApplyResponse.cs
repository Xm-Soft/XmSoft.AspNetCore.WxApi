using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationProductQrcodeApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
