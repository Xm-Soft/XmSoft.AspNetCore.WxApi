using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditPeContractUserstatusQueryResponse.
    /// </summary>
    public class ZhimaCreditPeContractUserstatusQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 对于用户状态2和3情况会返回用户最近签署的合约信息
        /// </summary>
        [XmlElement("contract_basic_info")]
        public ContractBasicInfo ContractBasicInfo { get; set; }

        /// <summary>
        /// 1：未参加活动（首签）  2：正在活动履约中  3：活动结束
        /// </summary>
        [XmlElement("user_status")]
        public long UserStatus { get; set; }

        /// <summary>
        /// 状态描述：  "never", "in promise", "promise complete"
        /// </summary>
        [XmlElement("user_status_desc")]
        public string UserStatusDesc { get; set; }
    }
}
