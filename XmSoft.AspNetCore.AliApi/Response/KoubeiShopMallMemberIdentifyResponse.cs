using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiShopMallMemberIdentifyResponse.
    /// </summary>
    public class KoubeiShopMallMemberIdentifyResponse : AliApiResponse
    {
        /// <summary>
        /// 会员卡编号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [XmlElement("has_card")]
        public bool HasCard { get; set; }
    }
}
