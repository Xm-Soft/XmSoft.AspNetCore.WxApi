using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// WhitehatInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WhitehatInfo : AliApiObject
    {
        /// <summary>
        /// 当前有效的安全币奖励
        /// </summary>
        [XmlElement("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 历史总金币奖励
        /// </summary>
        [XmlElement("history_coin")]
        public long HistoryCoin { get; set; }

        /// <summary>
        /// 称号
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
