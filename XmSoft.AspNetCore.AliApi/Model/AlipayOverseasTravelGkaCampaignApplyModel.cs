using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOverseasTravelGkaCampaignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelGkaCampaignApplyModel : AliApiObject
    {
        /// <summary>
        /// 活动id，获取方式：联系支付宝运营同学获取（适用于支付宝平台活动，由合作伙伴调用触发）
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 用户设备信息
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 外部传入的扩展信息，支付宝回调外部平台时会将其回传，方便外部作业务处理
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// rds嵌入页面的js收集的用户行为数据
        /// </summary>
        [XmlElement("json_ua")]
        public string JsonUa { get; set; }

        /// <summary>
        /// 用户参与活动的手机号
        /// </summary>
        [XmlElement("login_mobile")]
        public string LoginMobile { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。user_id、login_mobile两个参数至少有一个非空。使用优先级为 user_id > bind_mobile
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
