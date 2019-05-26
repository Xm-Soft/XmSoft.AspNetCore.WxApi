using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ContributeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ContributeDetail : AliApiObject
    {
        /// <summary>
        /// 出资方金额
        /// </summary>
        [XmlElement("contribute_amount")]
        public string ContributeAmount { get; set; }

        /// <summary>
        /// 出资方类型，如品牌商出资、支付宝平台出资等
        /// </summary>
        [XmlElement("contribute_type")]
        public string ContributeType { get; set; }
    }
}
