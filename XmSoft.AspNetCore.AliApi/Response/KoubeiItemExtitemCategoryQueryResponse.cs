using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("ext_category")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
