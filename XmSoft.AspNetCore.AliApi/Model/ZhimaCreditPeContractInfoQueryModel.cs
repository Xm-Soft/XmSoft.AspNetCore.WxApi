using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeContractInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractInfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 活动名称，由芝麻分配
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 电子合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 支付宝ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
