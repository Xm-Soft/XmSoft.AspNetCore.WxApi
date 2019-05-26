using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeUnionbankQueryModel : AliApiObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }
    }
}
