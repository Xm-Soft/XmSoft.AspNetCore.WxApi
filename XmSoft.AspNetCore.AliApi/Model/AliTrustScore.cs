using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AliTrustScore Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustScore : AliApiObject
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
