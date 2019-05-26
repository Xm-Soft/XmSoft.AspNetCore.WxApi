using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppSmsgDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSmsgDataSyncModel : AliApiObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("data_one")]
        public string DataOne { get; set; }

        /// <summary>
        /// abc
        /// </summary>
        [XmlElement("data_two")]
        public string DataTwo { get; set; }
    }
}
