using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// VehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleInfo : AliApiObject
    {
        /// <summary>
        /// 保险公司ID
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司对应的精友码（转码）
        /// </summary>
        [XmlElement("vehicle_code")]
        public string VehicleCode { get; set; }
    }
}
