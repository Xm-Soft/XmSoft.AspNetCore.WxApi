using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingVehicleQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 车牌信息（utf-8编码）
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }
    }
}
