using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeInfo : AliApiObject
    {
        /// <summary>
        /// 奖品使用地址
        /// </summary>
        [XmlElement("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 奖品金额,单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 奖品描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 奖品发放时间，格式为yyyy-MM-dd HH:mm:ss；有多个奖品时按发放时间倒序排列
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 奖品过期时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 奖品状态，可枚举，分别为“可用”(ENABLED)、“不可用”(DISABLED)、“未激活”(UNACTIVATED)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
