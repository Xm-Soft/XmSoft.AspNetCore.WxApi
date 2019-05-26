using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarParkingCardbarcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingCardbarcodeCreateModel : AliApiObject
    {
        /// <summary>
        /// 设备商订单id
        /// </summary>
        [XmlElement("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
