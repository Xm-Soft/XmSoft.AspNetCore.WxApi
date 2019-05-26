using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InsClaimPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimPolicy : AliApiObject
    {
        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
