using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayDataItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataItemGoodsList : AliApiObject
    {
        /// <summary>
        /// 单品的描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 单品id列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }
    }
}
