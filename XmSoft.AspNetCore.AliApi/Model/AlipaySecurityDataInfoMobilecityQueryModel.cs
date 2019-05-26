using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataInfoMobilecityQueryModel : AliApiObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
