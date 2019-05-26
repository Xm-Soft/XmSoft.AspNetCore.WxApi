using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayKeyanClass Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayKeyanClass : AliApiObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
