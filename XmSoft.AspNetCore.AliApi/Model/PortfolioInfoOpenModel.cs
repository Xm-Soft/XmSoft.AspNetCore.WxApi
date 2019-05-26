using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PortfolioInfoOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioInfoOpenModel : AliApiObject
    {
        /// <summary>
        /// 头图素材id
        /// </summary>
        [XmlElement("cover_image_id")]
        public string CoverImageId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举（PICTURE/VIDEO）
        /// </summary>
        [XmlElement("cover_image_type")]
        public string CoverImageType { get; set; }

        /// <summary>
        /// 头图链接
        /// </summary>
        [XmlElement("cover_image_url")]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [XmlElement("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [XmlElement("portfolio_title")]
        public string PortfolioTitle { get; set; }
    }
}
