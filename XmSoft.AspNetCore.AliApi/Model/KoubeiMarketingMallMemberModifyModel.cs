using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallMemberModifyModel : AliApiObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [XmlElement("card_info")]
        public MallCardUpdate CardInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
