using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOverseasTravelContentCountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCountSyncModel : AliApiObject
    {
        /// <summary>
        /// 计数信息列表
        /// </summary>
        [XmlArray("count_infos")]
        [XmlArrayItem("count_info")]
        public List<CountInfo> CountInfos { get; set; }
    }
}
