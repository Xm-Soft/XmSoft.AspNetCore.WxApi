using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdAduserqualificationBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 广告主用户资质列表 + 根据广告主用户id获得对应的资质列表
        /// </summary>
        [XmlArray("ad_user_qualification")]
        [XmlArrayItem("ad_user_qualification")]
        public List<AdUserQualification> AdUserQualification { get; set; }
    }
}
