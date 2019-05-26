using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PidShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PidShopInfo : AliApiObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// pid下的门店列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
