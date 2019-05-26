using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppCommonBillkeyQueryResponse.
    /// </summary>
    public class AlipayEbppCommonBillkeyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 户号列表
        /// </summary>
        [XmlArray("bill_key_list")]
        [XmlArrayItem("ebpp_bill_key")]
        public List<EbppBillKey> BillKeyList { get; set; }
    }
}
