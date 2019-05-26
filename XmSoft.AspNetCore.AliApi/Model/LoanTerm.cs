using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// LoanTerm Data Structure.
    /// </summary>
    [Serializable]
    public class LoanTerm : AliApiObject
    {
        /// <summary>
        /// 贷款期数
        /// </summary>
        [XmlElement("term")]
        public long Term { get; set; }

        /// <summary>
        /// 贷款期限单位，取值{D, M, Y}：D-日; M-月; Y-年
        /// </summary>
        [XmlElement("term_unit")]
        public string TermUnit { get; set; }
    }
}
