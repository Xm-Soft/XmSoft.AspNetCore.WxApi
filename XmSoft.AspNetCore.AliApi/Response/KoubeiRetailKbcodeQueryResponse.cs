using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailKbcodeQueryResponse.
    /// </summary>
    public class KoubeiRetailKbcodeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑码信息列表
        /// </summary>
        [XmlArray("code_info_list")]
        [XmlArrayItem("retail_kbcode_query_vo")]
        public List<RetailKbcodeQueryVo> CodeInfoList { get; set; }

        /// <summary>
        /// 口碑码总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
