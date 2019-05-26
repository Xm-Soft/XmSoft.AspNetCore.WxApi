using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
