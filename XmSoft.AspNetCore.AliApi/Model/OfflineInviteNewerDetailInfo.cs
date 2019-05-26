using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OfflineInviteNewerDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineInviteNewerDetailInfo : AliApiObject
    {
        /// <summary>
        /// 被邀请手机号
        /// </summary>
        [XmlElement("invited_phone")]
        public string InvitedPhone { get; set; }

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
        /// 用户实名时间
        /// </summary>
        [XmlElement("user_cert_time")]
        public string UserCertTime { get; set; }

        /// <summary>
        /// 用户领奖时间
        /// </summary>
        [XmlElement("user_prize_time")]
        public string UserPrizeTime { get; set; }
    }
}
