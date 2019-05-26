using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemExistedQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商品库中存在的商品编码
        /// </summary>
        [XmlArray("existed_list")]
        [XmlArrayItem("string")]
        public List<string> ExistedList { get; set; }
    }
}
