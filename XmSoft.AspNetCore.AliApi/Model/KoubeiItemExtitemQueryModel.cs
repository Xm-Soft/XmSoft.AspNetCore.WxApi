using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiItemExtitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemQueryModel : AliApiObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
