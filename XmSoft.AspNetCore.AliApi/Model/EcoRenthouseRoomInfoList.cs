using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// EcoRenthouseRoomInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoRenthouseRoomInfoList : AliApiObject
    {
        /// <summary>
        /// 房间参与免押金的到期日期YYYY-MM-dd
        /// </summary>
        [XmlElement("deposit_end_time")]
        public string DepositEndTime { get; set; }

        /// <summary>
        /// KA内部存储的房房间ID
        /// </summary>
        [XmlElement("ka_room_id")]
        public string KaRoomId { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [XmlElement("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// KA内部存储的房房间号
        /// </summary>
        [XmlElement("room_num")]
        public string RoomNum { get; set; }
    }
}
