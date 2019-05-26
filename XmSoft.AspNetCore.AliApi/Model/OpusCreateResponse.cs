using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OpusCreateResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpusCreateResponse : AliApiObject
    {
        /// <summary>
        /// 作品外部id
        /// </summary>
        [XmlElement("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [XmlElement("opus_id")]
        public string OpusId { get; set; }
    }
}
