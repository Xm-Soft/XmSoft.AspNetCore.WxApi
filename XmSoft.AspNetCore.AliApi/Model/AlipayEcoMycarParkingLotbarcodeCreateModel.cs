using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarParkingLotbarcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingLotbarcodeCreateModel : AliApiObject
    {
        /// <summary>
        /// 停车场编号
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
