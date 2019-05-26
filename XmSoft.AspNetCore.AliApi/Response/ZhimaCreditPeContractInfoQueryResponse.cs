using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditPeContractInfoQueryResponse.
    /// </summary>
    public class ZhimaCreditPeContractInfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户签署合约基本信息
        /// </summary>
        [XmlElement("contract_basic_info")]
        public ContractBasicInfo ContractBasicInfo { get; set; }

        /// <summary>
        /// 合约状态  0:  合约不存在 1：合约尚未完成 2：履约成功 3: 履约失败
        /// </summary>
        [XmlElement("contract_status")]
        public long ContractStatus { get; set; }

        /// <summary>
        /// 合约状态描述  "not found", "incompleted", "success", "fail"
        /// </summary>
        [XmlElement("contract_status_desc")]
        public string ContractStatusDesc { get; set; }
    }
}
