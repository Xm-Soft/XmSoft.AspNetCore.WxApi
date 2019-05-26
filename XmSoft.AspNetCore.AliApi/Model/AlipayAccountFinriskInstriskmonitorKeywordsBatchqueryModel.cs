using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 查询机构关键词
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
