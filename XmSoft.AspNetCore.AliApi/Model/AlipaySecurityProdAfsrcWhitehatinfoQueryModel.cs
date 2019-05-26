using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdAfsrcWhitehatinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcWhitehatinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// HavanaId(淘宝uid)
        /// </summary>
        [XmlElement("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
