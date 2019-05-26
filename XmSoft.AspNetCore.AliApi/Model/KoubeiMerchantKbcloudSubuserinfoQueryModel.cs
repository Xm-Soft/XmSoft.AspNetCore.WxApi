using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 主账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
