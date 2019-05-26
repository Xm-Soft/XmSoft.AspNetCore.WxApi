using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditEpFreedepositInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpFreedepositInitializeResponse : AliApiResponse
    {
        /// <summary>
        /// 免押额度业务流水号，每次业务唯一。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
