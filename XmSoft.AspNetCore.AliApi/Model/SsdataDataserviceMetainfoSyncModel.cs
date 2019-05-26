using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceMetainfoSyncModel : AliApiObject
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [XmlElement("meta_info")]
        public string MetaInfo { get; set; }
    }
}
