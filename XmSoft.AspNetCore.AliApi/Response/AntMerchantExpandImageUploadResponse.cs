using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandImageUploadResponse.
    /// </summary>
    public class AntMerchantExpandImageUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 图片在sfs中的标识
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
