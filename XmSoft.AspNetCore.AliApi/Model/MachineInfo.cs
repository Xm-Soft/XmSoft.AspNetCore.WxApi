using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MachineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MachineInfo : AliApiObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [XmlElement("machine_count")]
        public long MachineCount { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 设备类型，由商户定义
        /// </summary>
        [XmlElement("machine_type")]
        public string MachineType { get; set; }
    }
}
