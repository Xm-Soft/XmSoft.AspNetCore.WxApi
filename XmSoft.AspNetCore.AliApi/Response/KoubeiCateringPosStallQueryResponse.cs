using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosStallQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStallQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 未分配档口的菜品数目
        /// </summary>
        [XmlElement("no_set_stall")]
        public long NoSetStall { get; set; }

        /// <summary>
        /// 重复分配档口的菜品数目
        /// </summary>
        [XmlElement("repeat_set_stall")]
        public long RepeatSetStall { get; set; }

        /// <summary>
        /// 档口列表
        /// </summary>
        [XmlArray("stall_model_list")]
        [XmlArrayItem("stall_model")]
        public List<StallModel> StallModelList { get; set; }
    }
}
