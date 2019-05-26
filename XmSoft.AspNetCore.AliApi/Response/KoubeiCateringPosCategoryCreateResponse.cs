using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 新建菜类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
