using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthContractMerchantUnsignModel : AliApiObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
