using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// HoloGraphicContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HoloGraphicContactInfo : AliApiObject
    {
        /// <summary>
        /// 主叫通话频次
        /// </summary>
        [XmlElement("call_frequency")]
        public long CallFrequency { get; set; }

        /// <summary>
        /// 主叫通话时长
        /// </summary>
        [XmlElement("call_time")]
        public long CallTime { get; set; }

        /// <summary>
        /// 被叫通话频次
        /// </summary>
        [XmlElement("called_frequency")]
        public long CalledFrequency { get; set; }

        /// <summary>
        /// 被叫通话时长
        /// </summary>
        [XmlElement("called_time")]
        public long CalledTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 通话频次
        /// </summary>
        [XmlElement("talk_frequency")]
        public long TalkFrequency { get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [XmlElement("talk_time")]
        public long TalkTime { get; set; }
    }
}
