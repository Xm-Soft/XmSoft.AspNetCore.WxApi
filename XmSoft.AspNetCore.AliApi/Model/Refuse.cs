using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// Refuse Data Structure.
    /// </summary>
    [Serializable]
    public class Refuse : AliApiObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
