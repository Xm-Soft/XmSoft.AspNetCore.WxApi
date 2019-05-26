using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantSignResponse.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantSignResponse : AliApiResponse
    {
        /// <summary>
        /// 合约批次号
        /// </summary>
        [XmlElement("contract_batch_no")]
        public string ContractBatchNo { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlArray("contract_no_list")]
        [XmlArrayItem("string")]
        public List<string> ContractNoList { get; set; }
    }
}
