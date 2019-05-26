using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionAdvchannelUnbindModel : AliApiObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [XmlElement("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID列表
        /// </summary>
        [XmlArray("channel_id_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelIdList { get; set; }
    }
}
