using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditPeContractUserhistoryQueryResponse.
    /// </summary>
    public class ZhimaCreditPeContractUserhistoryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户历史签约信息
        /// </summary>
        [XmlArray("contract_history")]
        [XmlArrayItem("contract_basic_info")]
        public List<ContractBasicInfo> ContractHistory { get; set; }
    }
}
