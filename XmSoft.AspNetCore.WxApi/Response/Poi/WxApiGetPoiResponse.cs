using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace XmSoft.AspNetCore.WxApi.Response.Poi
{
    /// <summary>
    /// 获取门店信息
    /// </summary>
    public class WxApiGetPoiResponse : WxApiResponse
    {
        /// <summary>
        /// 获取门店信息
        /// </summary>
        public WxApiGetPoiResponse()
        {

        }
        

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonProperty(PropertyName = "business")]
        public Business business { get; set; }
    }
    /// <summary>
    /// 门店
    /// </summary>
    public class Business
    {
        /// <summary>
        /// 基础数据
        /// </summary>
        public BaseInfo base_info { get; set; }
    }
    /// <summary>
    /// 门店基础信息
    /// </summary>
    public class BaseInfo
    {
        /// <summary>
        /// 商户自己的id，用于后续审核通过收到poi_id 的通知时，做对应关系。请商户自己保证唯一识别性
        /// </summary>
        public string sid { get; set; }
        /// <summary>
        /// 门店名称（仅为商户名，如：国美、麦当劳，不应包含地区、地址、分店名等信息，错误示例：北京国美） 不能为空，15个汉字或30个英文字符内
        /// </summary>
        public string business_name { get; set; }
        /// <summary>
        /// 分店名称（不应包含地区信息，不应与门店名有重复，错误示例：北京王府井店） 20 个字 以内
        /// </summary>
        public string branch_name { get; set; }
        /// <summary>
        /// 门店所在的省份（直辖市填城市名,如：北京 市） 10个字 以内
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 门店所在的城市 10个字 以内
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 门店所在地区 10个字 以内
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 门店所在的详细街道地址（不要填写省市信息）
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 门店的电话（纯数字，区号、分机号均由“-”隔开）
        /// </summary>
        public string telephone { get; set; }
        /// <summary>
        /// 门店的类型（不同级分类用“,”隔开，如：美食，川菜，火锅。详细分类参见附件：微信门店类目表）
        /// </summary>
        public string[] categories { get; set; }
        /// <summary>
        /// 坐标类型： 1 为火星坐标 2 为sogou经纬度 3 为百度经纬度 4 为mapbar经纬度 
        /// <para>5 为GPS坐标 6 为sogou墨卡托坐标 注：高德经纬度无需转换可直接使用</para>
        /// </summary>
        public int offset_type { get; set; }
        /// <summary>
        /// 门店所在地理位置的经度
        /// </summary>
        public decimal longitude { get; set; }
        /// <summary>
        /// 门店所在地理位置的纬度（经纬度均为火星坐标，最好选用腾讯地图标记的坐标）
        /// </summary>
        public decimal latitude { get; set; }
        /// <summary>
        /// 图片列表，url 形式，可以有多张图片，尺寸为 640*340px。必须为上一接口生成的url。 
        /// <para>图片内容不允许与门店不相关，不允许为二维码、员工合照（或模特肖像）、营业执照、无门店正门的街景、地图截图、公交地铁站牌、菜单截图等</para>
        /// </summary>
        public List<PictureList> photo_list { get; set; }
        /// <summary>
        /// 推荐品，餐厅可为推荐菜；酒店为推荐套房；景点为推荐游玩景点等，针对自己行业的推荐内容 200字以内
        /// </summary>
        public string recommend { get; set; }
        /// <summary>
        /// 特色服务，如免费wifi，免费停车，送货上门等商户能提供的特色功能或服务
        /// </summary>
        public string special { get; set; }
        /// <summary>
        /// 商户简介，主要介绍商户信息等 300字以内
        /// </summary>
        public string introduction { get; set; }
        /// <summary>
        /// 	营业时间，24 小时制表示，用“-”连接，如 8:00-20:00
        /// </summary>
        public string open_time { get; set; }
        /// <summary>
        /// 人均价格，大于0 的整数
        /// </summary>
        public int avg_price { get; set; }

        public int available_state { get; set; }
        public int update_status { get; set; }
    }
    /// <summary>
    /// 图片信息
    /// </summary>
    public class PictureList
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        public string photo_url { get; set; }
    }
}
