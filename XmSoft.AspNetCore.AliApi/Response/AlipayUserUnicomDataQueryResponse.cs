using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserUnicomDataQueryResponse.
    /// </summary>
    public class AlipayUserUnicomDataQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 蚂蚁宝卡流量余额，单位M
        /// </summary>
        [XmlElement("data_balance")]
        public long DataBalance { get; set; }
    }
}
