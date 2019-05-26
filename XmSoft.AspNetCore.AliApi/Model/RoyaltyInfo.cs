using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyInfo : AliApiObject
    {
        /// <summary>
        /// 分账明细的信息，可以描述多条分账指令，json数组。
        /// </summary>
        [XmlArray("royalty_detail_infos")]
        [XmlArrayItem("royalty_detail_infos")]
        public List<RoyaltyDetailInfos> RoyaltyDetailInfos { get; set; }

        /// <summary>
        /// 分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
