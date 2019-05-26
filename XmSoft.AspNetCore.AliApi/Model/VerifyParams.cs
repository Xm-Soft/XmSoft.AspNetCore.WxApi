using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// VerifyParams Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyParams : AliApiObject
    {
        /// <summary>
        /// 用户证件号后4位
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }
    }
}
