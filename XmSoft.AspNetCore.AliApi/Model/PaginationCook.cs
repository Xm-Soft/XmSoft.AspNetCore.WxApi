using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PaginationCook Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationCook : AliApiObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("kbdish_cook_info")]
        public List<KbdishCookInfo> List { get; set; }

        /// <summary>
        /// 表示当前页数
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
