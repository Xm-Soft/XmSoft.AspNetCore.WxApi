using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceDataBatchqueryResponse.
    /// </summary>
    public class AlipayCreditAutofinanceDataBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 订单数据查询的返回值。通过列表方式批量返回机构的订单查询数据。通过系统控制返回的数据中不包含客户的敏感信息。
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("scene_data_query_result_detail")]
        public List<SceneDataQueryResultDetail> ResultData { get; set; }
    }
}
