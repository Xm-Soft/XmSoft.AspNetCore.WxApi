using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MActivityDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MActivityDetailInfo : AliApiObject
    {
        /// <summary>
        /// 口碑营销活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动当前状态信息，目前枚举值：草稿：CREATED、已生效：ENABLED、已启动：STARTED、已下架：CLOSED、已完成：FINISHED
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动是否需要自动续期
        /// </summary>
        [XmlElement("auto_delay_flag")]
        public bool AutoDelayFlag { get; set; }

        /// <summary>
        /// 活动所属场景，目前支持枚举类型：点餐场景：DISH、预点餐场景：PRE_DISH、菜单场景：MENU
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 指定creator字段创建人类型，目前支持枚举：外部商户：MER、商户操作员：MER_OPERATOR、外部服务商：PROVIDER、外部服务商员工：PROVIDER_STAFF
        /// </summary>
        [XmlElement("creator_type")]
        public string CreatorType { get; set; }

        /// <summary>
        /// 活动描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 页面展示状态信息，查询结果返回Code码，目前支持code和对应说明：初始状态：CAMP_CREATED、待确认：CAMP_CONFIRM、已启用未开始：CAMP_TIME_YET、进行中：CAMP_GOING、活动修改中：CAMP_MODIFYING、活动下架中：CAMP_CLOSING、已下架：CAMP_ENDED、已结束：CAMP_EXPIRED、已驳回：CAMP_REJECTED
        /// </summary>
        [XmlElement("display_status")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息数据，如需要透传信息到口碑，需要结果带回，则传递该值
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("m_ext_info")]
        public List<MExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 营销活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 活动外部业务类型，通过改类型指定营销活动是什么类型的活动，目前支持类型枚举值：会员券：MEMBER_CASH、会员折扣：MEMBER_RATE_DISCOUNT、会员价：MEMBER_DISH_ITEM
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 所属人，一般所属人为商户pid
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 指定owner_id所属人字段类型，目前支持枚举：外部商户：MER
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 营销活动玩法详细信息设置
        /// </summary>
        [XmlArray("promo_info_list")]
        [XmlArrayItem("m_promo_info")]
        public List<MPromoInfo> PromoInfoList { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
