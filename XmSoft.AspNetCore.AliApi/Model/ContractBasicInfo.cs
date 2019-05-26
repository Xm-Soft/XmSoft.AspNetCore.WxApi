using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ContractBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractBasicInfo : AliApiObject
    {
        /// <summary>
        /// 合约简要描述
        /// </summary>
        [XmlElement("brief_desc")]
        public string BriefDesc { get; set; }

        /// <summary>
        /// 合约中文名
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合约过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 最后守约时间
        /// </summary>
        [XmlElement("last_promise_date")]
        public string LastPromiseDate { get; set; }

        /// <summary>
        /// 用户在输入场景下签约合同的序号
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 合约签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 合同签约应用app标识
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 合同状态，可选值：success, fail
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
