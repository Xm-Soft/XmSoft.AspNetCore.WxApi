using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoanapplyArrangementQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyArrangementQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询指定客户、产品下客户签订的合约状态等信息
        /// </summary>
        [XmlArray("arrangement_query_result")]
        [XmlArrayItem("arrangement_open_query_result_v_o")]
        public List<ArrangementOpenQueryResultVO> ArrangementQueryResult { get; set; }
    }
}
