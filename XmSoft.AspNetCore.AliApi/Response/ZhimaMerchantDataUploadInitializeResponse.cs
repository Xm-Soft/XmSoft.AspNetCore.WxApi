using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaMerchantDataUploadInitializeResponse.
    /// </summary>
    public class ZhimaMerchantDataUploadInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 行业模板
        /// </summary>
        [XmlElement("template_url")]
        public string TemplateUrl { get; set; }
    }
}
