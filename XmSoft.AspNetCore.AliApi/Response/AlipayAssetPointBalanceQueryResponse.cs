using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayAssetPointBalanceQueryResponse.
    /// </summary>
    public class AlipayAssetPointBalanceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }
    }
}
