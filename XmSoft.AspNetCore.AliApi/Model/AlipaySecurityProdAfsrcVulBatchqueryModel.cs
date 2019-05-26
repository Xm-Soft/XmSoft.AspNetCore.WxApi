using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcVulBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
