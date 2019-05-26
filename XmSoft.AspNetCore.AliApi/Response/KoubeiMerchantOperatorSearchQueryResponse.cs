using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorSearchQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 根据不同条件查询返回的口碑商家中心操作员列表
        /// </summary>
        [XmlArray("operator_list")]
        [XmlArrayItem("operator_base_info")]
        public List<OperatorBaseInfo> OperatorList { get; set; }

        /// <summary>
        /// 操作员列表查询结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
