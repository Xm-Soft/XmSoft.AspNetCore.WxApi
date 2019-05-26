using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPointBalanceGetResponse.
    /// </summary>
    public class AlipayPointBalanceGetResponse : AliApiResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }
    }
}
