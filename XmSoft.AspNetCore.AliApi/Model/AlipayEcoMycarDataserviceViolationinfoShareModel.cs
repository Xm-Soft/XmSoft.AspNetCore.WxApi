using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AliApiObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
