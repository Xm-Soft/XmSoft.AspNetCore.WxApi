using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestCloudacptActivityQueryModel : AliApiObject
    {
        /// <summary>
        /// partener id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
