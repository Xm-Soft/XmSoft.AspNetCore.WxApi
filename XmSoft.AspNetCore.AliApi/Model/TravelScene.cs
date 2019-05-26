using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// TravelScene Data Structure.
    /// </summary>
    [Serializable]
    public class TravelScene : AliApiObject
    {
        /// <summary>
        /// 出行场景，综合体入参列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("travel_mall_request")]
        public List<TravelMallRequest> DataList { get; set; }
    }
}
