using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemBrandQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBrandQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 品牌列表信息
        /// </summary>
        [XmlArray("brand_list")]
        [XmlArrayItem("ext_brand")]
        public List<ExtBrand> BrandList { get; set; }
    }
}
