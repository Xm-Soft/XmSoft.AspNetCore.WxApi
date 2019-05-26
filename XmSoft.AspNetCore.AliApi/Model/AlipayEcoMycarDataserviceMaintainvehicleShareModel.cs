using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AliApiObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
