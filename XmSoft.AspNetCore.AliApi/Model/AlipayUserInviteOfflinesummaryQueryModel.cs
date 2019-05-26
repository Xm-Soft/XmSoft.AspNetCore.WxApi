using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteOfflinesummaryQueryModel : AliApiObject
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
    }
}
