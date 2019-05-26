using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSceneprodBillQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodBillQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 网商银行申请单号
        /// </summary>
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("scene_prod_bill_detail")]
        public List<SceneProdBillDetail> BillList { get; set; }

        /// <summary>
        /// 支用号，银行直投模式这个才有值
        /// </summary>
        [XmlElement("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
