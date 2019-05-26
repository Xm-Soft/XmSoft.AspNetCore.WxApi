using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDialogonlineVehicleQueryModel : AliApiObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
