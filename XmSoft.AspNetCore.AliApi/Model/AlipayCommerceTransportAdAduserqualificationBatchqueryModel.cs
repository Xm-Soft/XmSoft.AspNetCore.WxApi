using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdAduserqualificationBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 广告主用户id + 根据广告主用户id查询对应的广告主资质列表
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }
    }
}
