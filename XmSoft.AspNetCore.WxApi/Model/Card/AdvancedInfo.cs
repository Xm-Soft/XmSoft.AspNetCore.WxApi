using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    /// <summary>
    /// 创建优惠券特有的高级字段
    /// </summary>
    public class AdvancedInfo
    {
        /// <summary>
        /// 使用门槛（条件）字段，若不填写使用条件则在券面拼写 ：无最低消费限制，全场通用，不限品类；并在使用说明显示： 可与其他优惠共享
        /// </summary>
        public use_condition use_condition { get; set; }
        /// <summary>
        /// 封面摘要结构体名称
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public Abstract _abstract{ get; set;}
        /// <summary>
        /// 图文列表，显示在详情内页 ，优惠券券开发者须至少传入 一组图文列表
        /// </summary>
        public List<text_image_list> text_image_list { get; set; }
        /// <summary>
        /// 使用时段限制，包含以下字段
        /// </summary>
        public List<time_limit> time_limit { get; set; }
        /// <summary>
        /// 商家服务类型： BIZ_SERVICE_DELIVER 外卖服务； BIZ_SERVICE_FREE_PARK 停车位； BIZ_SERVICE_WITH_PET 可带宠物； BIZ_SERVICE_FREE_WIFI 免费wifi， 可多选
        /// </summary>
        public string[] business_service { get; set; }
    }
    public class use_condition
    {
        /// <summary>
        /// 非必填 指定可用的商品类目，仅用于代金券类型 ，填入后将在券面拼写适用于xxx
        /// </summary>
        public string accept_category { get; set; }
        /// <summary>
        /// 非必填 指定不可用的商品类目，仅用于代金券类型 ，填入后将在券面拼写不适用于xxxx
        /// </summary>
        public string reject_category { get; set; }
        /// <summary>
        /// 非必填 满减门槛字段，可用于兑换券和代金券 ，填入后将在全面拼写消费满xx元可用。
        /// </summary>
        public int least_cost { get; set; }
        /// <summary>
        /// 非必填 购买xx可用类型门槛，仅用于兑换 ，填入后自动拼写购买xxx可用。
        /// </summary>
        public string object_use_for { get; set; }
        /// <summary>
        ///非必填 不可以与其他类型共享门槛 ，填写false时系统将在使用须知里 拼写“不可与其他优惠共享”， 填写true时系统将在使用须知里 拼写“可与其他优惠共享”， 默认为true
        /// </summary>
        public bool? can_use_with_other_discount { get; set; }
    }
    public class Abstract
    {
        /// <summary>
        ///非必填 封面摘要简介。
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public string _abstract { get;set;}
        /// <summary>
        ///非必填 封面图片列表，仅支持填入一 个封面图片链接， 上传图片接口 上传获取图片获得链接，填写 非CDN链接会报错，并在此填入。 建议图片尺寸像素850*350
        /// </summary>
        public string[] icon_url_list { get; set; }
    }
    public class text_image_list
    {
        /// <summary>
        /// 非必填 图片链接，必须调用 上传图片接口 上传图片获得链接，并在此填入， 否则报错
        /// </summary>
        public string image_url { get; set; }
        /// <summary>
        ///非必填 图文描述
        /// </summary>
        public string text { get; set; }
    }
    public class time_limit
    {
        /// <summary>
        /// 非必填 限制类型枚举值：支持填入 MONDAY 周一 TUESDAY 周二 WEDNESDAY 周三 THURSDAY 周四 FRIDAY 周五 SATURDAY 周六 SUNDAY 周日 此处只控制显示， 不控制实际使用逻辑，不填默认不显示
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 非必填 当前type类型下的起始时间（小时） ，如当前结构体内填写了MONDAY， 此处填写了10，则此处表示周一 10:00可用
        /// </summary>
        public int? begin_hour { get; set; }
        /// <summary>
        /// 非必填 当前type类型下的结束时间（小时） ，如当前结构体内填写了MONDAY， 此处填写了20， 则此处表示周一 10:00-20:00可用
        /// </summary>
        public int? end_hour { get; set; }
        /// <summary>
        ///非必填 	当前type类型下的起始时间（分钟） ，如当前结构体内填写了MONDAY， begin_hour填写10，此处填写了59， 则此处表示周一 10:59可用
        /// </summary>
        public int? begin_minute { get; set; }
        /// <summary>
        /// 非必填  当前type类型下的结束时间（分钟） ，如当前结构体内填写了MONDAY， begin_hour填写10，此处填写了59， 则此处表示周一 10:59-00:59可用
        /// </summary>
        public int? end_minute { get; set; }
    }
}
