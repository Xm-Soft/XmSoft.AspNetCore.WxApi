using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoCplifeRooominfoQueryResponse.
    /// </summary>
    public class AlipayEcoCplifeRooominfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 符合条件的小区房屋信息列表.
        /// </summary>
        [XmlArray("room_info")]
        [XmlArrayItem("cplife_room_detail")]
        public List<CplifeRoomDetail> RoomInfo { get; set; }
    }
}
