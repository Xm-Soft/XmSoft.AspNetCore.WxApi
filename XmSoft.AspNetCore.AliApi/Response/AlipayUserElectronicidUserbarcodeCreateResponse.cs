using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserElectronicidUserbarcodeCreateResponse.
    /// </summary>
    public class AlipayUserElectronicidUserbarcodeCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 用户电子身份证码串
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }
    }
}
