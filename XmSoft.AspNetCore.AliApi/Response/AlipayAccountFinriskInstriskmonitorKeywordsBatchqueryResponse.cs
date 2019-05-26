using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse.
    /// </summary>
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回机构关键词相关信息
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("string")]
        public List<string> Result { get; set; }
    }
}
