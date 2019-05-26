using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OfflineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineInviteNewerSummaryInfo : AliApiObject
    {
        /// <summary>
        /// 二级渠道
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 结算日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 实名用户数
        /// </summary>
        [XmlElement("user_cert_count")]
        public long UserCertCount { get; set; }

        /// <summary>
        /// 可结算实名用户数
        /// </summary>
        [XmlElement("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 权益核销用户数
        /// </summary>
        [XmlElement("user_consume_count")]
        public long UserConsumeCount { get; set; }

        /// <summary>
        /// 可结算核销用户数
        /// </summary>
        [XmlElement("user_consume_settle_count")]
        public long UserConsumeSettleCount { get; set; }

        /// <summary>
        /// 权益领取用户数
        /// </summary>
        [XmlElement("user_prize_count")]
        public long UserPrizeCount { get; set; }
    }
}
