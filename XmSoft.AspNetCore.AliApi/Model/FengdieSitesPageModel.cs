using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FengdieSitesPageModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesPageModel : AliApiObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 是否为首页
        /// </summary>
        [XmlElement("is_home_page")]
        public bool IsHomePage { get; set; }

        /// <summary>
        /// 首页原始 url，仅在 isHomePage = true 时候才存在
        /// </summary>
        [XmlElement("origin_url")]
        public string OriginUrl { get; set; }

        /// <summary>
        /// 活动页面 schema 数据
        /// </summary>
        [XmlArray("schema")]
        [XmlArrayItem("fengdie_activity_schema_model")]
        public List<FengdieActivitySchemaModel> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 页面访问地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
