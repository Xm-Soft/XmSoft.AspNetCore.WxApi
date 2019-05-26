using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAccountExrateSourcerateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateSourcerateQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 源汇率记录
        /// </summary>
        [XmlArray("source_rate_list")]
        [XmlArrayItem("ex_source_rate_v_o")]
        public List<ExSourceRateVO> SourceRateList { get; set; }
    }
}
