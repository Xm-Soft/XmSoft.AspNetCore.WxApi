using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryResponse.
    /// </summary>
    public class AlipayOpenAgentSignstatusQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商户产品签约状态结果对象数组，返回本次查询的产品的签约状态
        /// </summary>
        [XmlArray("sign_status_list")]
        [XmlArrayItem("product_sign_status_info")]
        public List<ProductSignStatusInfo> SignStatusList { get; set; }
    }
}
