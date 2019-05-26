using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenDataServiceQueryResponse.
    /// </summary>
    public class AlipayOpenDataServiceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("group_records")]
        [XmlArrayItem("group_record")]
        public List<GroupRecord> GroupRecords { get; set; }

        /// <summary>
        /// 是否成功  true：成功  false:失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
