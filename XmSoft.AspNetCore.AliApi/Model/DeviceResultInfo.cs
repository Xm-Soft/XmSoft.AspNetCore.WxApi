using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// DeviceResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceResultInfo : AliApiObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务数据类型
        /// </summary>
        [XmlElement("device_label")]
        public string DeviceLabel { get; set; }
    }
}
