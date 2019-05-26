using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbtstabcQueryModel : AliApiObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwbaa")]
        public string Xwbaa { get; set; }
    }
}
