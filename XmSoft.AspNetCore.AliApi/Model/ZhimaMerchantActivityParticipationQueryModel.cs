using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityParticipationQueryModel : AliApiObject
    {
        /// <summary>
        /// 承诺消费合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
