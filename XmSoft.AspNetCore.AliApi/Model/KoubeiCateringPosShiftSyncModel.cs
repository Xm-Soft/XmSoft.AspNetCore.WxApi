using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosShiftSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosShiftSyncModel : AliApiObject
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [XmlArray("schedules")]
        [XmlArrayItem("shop_pos_schedule")]
        public List<ShopPosSchedule> Schedules { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
