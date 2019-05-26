using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
