using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KeyanColumn Data Structure.
    /// </summary>
    [Serializable]
    public class KeyanColumn : AliApiObject
    {
        /// <summary>
        /// 密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }
    }
}
