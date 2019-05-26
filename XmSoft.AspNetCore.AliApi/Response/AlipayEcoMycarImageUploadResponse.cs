using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarImageUploadResponse.
    /// </summary>
    public class AlipayEcoMycarImageUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 图片Id
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 图片地址，url全是小写
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }
    }
}
