using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenDataServiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDataServiceQueryModel : AliApiObject
    {
        /// <summary>
        /// 发起查询的客户端版本号
        /// </summary>
        [XmlElement("client_info")]
        public ClientInfo ClientInfo { get; set; }

        /// <summary>
        /// 每页最多显示的搜索结果数量，默认值20
        /// </summary>
        [XmlElement("limit_size")]
        public long LimitSize { get; set; }

        /// <summary>
        /// 用户所处的地理位置信息
        /// </summary>
        [XmlElement("location_info")]
        public LocationInfo LocationInfo { get; set; }

        /// <summary>
        /// 用户输入的搜索请求
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 场景code，由appxsearch分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户每发起一次请求的唯一ID
        /// </summary>
        [XmlElement("search_id")]
        public string SearchId { get; set; }

        /// <summary>
        /// 同一个用户同一个session中发起的搜索请求
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 显示搜索结果的起始位置，默认值0
        /// </summary>
        [XmlElement("start_num")]
        public long StartNum { get; set; }

        /// <summary>
        /// 用户的支付宝ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
