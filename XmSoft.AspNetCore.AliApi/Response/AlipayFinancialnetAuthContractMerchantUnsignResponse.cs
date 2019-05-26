using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantUnsignResponse.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantUnsignResponse : AliApiResponse
    {
        /// <summary>
        /// 合约批次号列表
        /// </summary>
        [XmlArray("contract_batch_no_list")]
        [XmlArrayItem("string")]
        public List<string> ContractBatchNoList { get; set; }

        /// <summary>
        /// 合约号列表
        /// </summary>
        [XmlArray("contract_no_list")]
        [XmlArrayItem("string")]
        public List<string> ContractNoList { get; set; }
    }
}
