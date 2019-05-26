using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicThirdCustomerServiceModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicThirdCustomerServiceModel : AliApiObject
    {
        /// <summary>
        /// 服务窗商户在渠道商处对应的用户id
        /// </summary>
        [XmlElement("channel_uid")]
        public string ChannelUid { get; set; }
    }
}
