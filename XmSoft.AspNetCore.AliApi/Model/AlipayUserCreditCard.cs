using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCreditCard : AliApiObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
