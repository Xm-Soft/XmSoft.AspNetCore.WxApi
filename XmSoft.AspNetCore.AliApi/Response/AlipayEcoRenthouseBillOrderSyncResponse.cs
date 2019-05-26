using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderSyncResponse : AliApiResponse
    {
        /// <summary>
        /// billNo-账单编号  status-1:成功
        /// </summary>
        [XmlArray("result_bill_list")]
        [XmlArrayItem("string")]
        public List<string> ResultBillList { get; set; }
    }
}
