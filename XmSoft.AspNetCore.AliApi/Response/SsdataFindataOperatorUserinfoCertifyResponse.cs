using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataFindataOperatorUserinfoCertifyResponse.
    /// </summary>
    public class SsdataFindataOperatorUserinfoCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 系统业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 返回的表单key值
        /// </summary>
        [XmlArray("form_list")]
        [XmlArrayItem("string")]
        public List<string> FormList { get; set; }

        /// <summary>
        /// 商户系统的业务流水号
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }
    }
}
