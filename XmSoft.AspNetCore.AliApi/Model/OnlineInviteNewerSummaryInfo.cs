using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OnlineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineInviteNewerSummaryInfo : AliApiObject
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
        /// 日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 可结算实名数
        /// </summary>
        [XmlElement("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 可结算新登数
        /// </summary>
        [XmlElement("user_new_settle_count")]
        public long UserNewSettleCount { get; set; }
    }
}
