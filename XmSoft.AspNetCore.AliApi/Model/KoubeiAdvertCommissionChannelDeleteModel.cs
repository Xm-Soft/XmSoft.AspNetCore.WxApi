using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelDeleteModel : AliApiObject
    {
        /// <summary>
        /// 需要删除的渠道ID列表
        /// </summary>
        [XmlArray("channel_ids")]
        [XmlArrayItem("string")]
        public List<string> ChannelIds { get; set; }
    }
}
