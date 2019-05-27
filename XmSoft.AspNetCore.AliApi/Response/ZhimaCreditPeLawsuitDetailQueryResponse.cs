using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditPeLawsuitDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditPeLawsuitDetailQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 个人涉诉详情信息
        /// </summary>
        [XmlElement("lawsuit_detail")]
        public EpInfo LawsuitDetail { get; set; }
    }
}