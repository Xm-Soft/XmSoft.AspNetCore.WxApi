using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenOperatorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperatorSyncModel : AliApiObject
    {
        /// <summary>
        /// 主账号的userId
        /// </summary>
        [XmlElement("master_user_id")]
        public string MasterUserId { get; set; }

        /// <summary>
        /// 产品code，FINCLOUD=金融云，CSC=云客服
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
