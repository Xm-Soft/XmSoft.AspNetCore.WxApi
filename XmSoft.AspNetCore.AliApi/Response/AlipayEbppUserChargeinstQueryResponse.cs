using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppUserChargeinstQueryResponse.
    /// </summary>
    public class AlipayEbppUserChargeinstQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 提供给邦道的接口，查询用户常缴机构与常住城市信息，该对象为输出具体内容。
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("query_user_charge_inst_and_area_info")]
        public List<QueryUserChargeInstAndAreaInfo> DataList { get; set; }
    }
}
