using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝返回停车场id。成功不为空，失败返回空
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
