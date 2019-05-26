using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingToolPrizesendAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPrizesendAuthModel : AliApiObject
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 外部流水号，保证业务幂等性
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 发奖用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
