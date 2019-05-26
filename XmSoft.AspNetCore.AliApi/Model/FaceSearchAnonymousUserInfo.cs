using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FaceSearchAnonymousUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchAnonymousUserInfo : AliApiObject
    {
        /// <summary>
        /// 商户标识
        /// </summary>
        [XmlElement("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [XmlElement("merchantuid")]
        public string Merchantuid { get; set; }
    }
}
