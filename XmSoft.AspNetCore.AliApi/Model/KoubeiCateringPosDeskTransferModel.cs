using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDeskTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskTransferModel : AliApiObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [XmlArray("sort_area")]
        [XmlArrayItem("desk_area_entity")]
        public List<DeskAreaEntity> SortArea { get; set; }

        /// <summary>
        /// 桌位排序list
        /// </summary>
        [XmlArray("sort_desk")]
        [XmlArrayItem("sort_desk_param")]
        public List<SortDeskParam> SortDesk { get; set; }
    }
}
