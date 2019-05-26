using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeUnionbankQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 联行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 市区信息
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("prov")]
        public string Prov { get; set; }
    }
}
