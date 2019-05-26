using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdUmidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdUmidQueryModel : AliApiObject
    {
        /// <summary>
        /// tokenID,客户端对应的token值: token由应用系统生成, 缓存在前台页面, 生成UMID的时候会传到UMID系统
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }
    }
}
