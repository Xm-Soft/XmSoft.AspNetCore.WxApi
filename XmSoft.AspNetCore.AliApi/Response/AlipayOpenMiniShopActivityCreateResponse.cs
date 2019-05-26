using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCreateResponse.
    /// </summary>
    public class AlipayOpenMiniShopActivityCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 业务处理流水号，唯一，可以根据该流水号进行活动取消
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
