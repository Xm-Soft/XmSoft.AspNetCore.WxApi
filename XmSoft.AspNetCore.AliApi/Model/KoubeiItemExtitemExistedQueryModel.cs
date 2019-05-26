using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemExistedQueryModel : AliApiObject
    {
        /// <summary>
        /// 商品编码列表, 商品编码数量不超过100条。
        /// </summary>
        [XmlArray("code_list")]
        [XmlArrayItem("string")]
        public List<string> CodeList { get; set; }
    }
}
