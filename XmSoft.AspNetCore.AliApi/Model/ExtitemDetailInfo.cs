using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ExtitemDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtitemDetailInfo : AliApiObject
    {
        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("extitem_id")]
        public string ExtitemId { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [XmlElement("extitem_name")]
        public string ExtitemName { get; set; }

        /// <summary>
        /// 标品的货品组成
        /// </summary>
        [XmlArray("goods_component_list")]
        [XmlArrayItem("goods_component")]
        public List<GoodsComponent> GoodsComponentList { get; set; }
    }
}
