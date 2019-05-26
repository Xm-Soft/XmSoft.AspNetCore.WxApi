using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppSmgMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSmgMsgSendModel : AliApiObject
    {
        /// <summary>
        /// 5555
        /// </summary>
        [XmlElement("numberone")]
        public string Numberone { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [XmlElement("numbertowe")]
        public string Numbertowe { get; set; }
    }
}
