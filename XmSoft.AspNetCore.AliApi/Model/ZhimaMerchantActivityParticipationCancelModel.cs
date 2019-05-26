using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityParticipationCancelModel : AliApiObject
    {
        /// <summary>
        /// 承诺消费合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
