using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingAgreementQueryModel : AliApiObject
    {
        /// <summary>
        /// 车牌，用户车辆进场时ISV设备识别到的车辆牌照
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }
    }
}
