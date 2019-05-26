using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCancelResponse.
    /// </summary>
    public class AlipayOpenMiniShopActivityCancelResponse : AliApiResponse
    {
        /// <summary>
        /// 返回传入的业务处理流水号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
