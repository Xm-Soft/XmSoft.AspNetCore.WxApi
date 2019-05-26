using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AliApiResponse
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        [XmlElement("info")]
        public MaintainVehicleInfo Info { get; set; }
    }
}
