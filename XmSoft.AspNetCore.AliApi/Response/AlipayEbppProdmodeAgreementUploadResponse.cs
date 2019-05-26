using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppProdmodeAgreementUploadResponse.
    /// </summary>
    public class AlipayEbppProdmodeAgreementUploadResponse : AliApiResponse
    {
        /// <summary>
        /// true:表示上传文件成功  false:表示上传文件失败
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 上传文件成功备注说明。
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
