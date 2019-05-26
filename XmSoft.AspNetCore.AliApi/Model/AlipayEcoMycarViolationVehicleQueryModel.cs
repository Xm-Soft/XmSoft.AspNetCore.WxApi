using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarViolationVehicleQueryModel : AliApiObject
    {
        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
