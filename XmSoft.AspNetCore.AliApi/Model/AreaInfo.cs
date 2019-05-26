using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AreaInfo : AliApiObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
