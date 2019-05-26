using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }
    }
}
