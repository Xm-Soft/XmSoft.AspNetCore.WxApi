using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// EcoRenthouseOtherAmount Data Structure.
    /// </summary>
    [Serializable]
    public class EcoRenthouseOtherAmount : AliApiObject
    {
        /// <summary>
        /// 30
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 费用单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
