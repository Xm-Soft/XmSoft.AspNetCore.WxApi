using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDeskQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 餐台信息
        /// </summary>
        [XmlArray("pos_desk_list")]
        [XmlArrayItem("desk_entity")]
        public List<DeskEntity> PosDeskList { get; set; }
    }
}
