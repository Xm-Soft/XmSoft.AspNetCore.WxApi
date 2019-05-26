using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataFindataOperatorSmsQueryResponse.
    /// </summary>
    public class SsdataFindataOperatorSmsQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 系统业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户的业务流水号
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }
    }
}
