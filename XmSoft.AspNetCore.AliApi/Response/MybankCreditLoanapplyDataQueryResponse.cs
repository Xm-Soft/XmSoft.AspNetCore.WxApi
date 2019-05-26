using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditLoanapplyDataQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyDataQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询到的对应的数据，大字段。
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据采集到的时间
        /// </summary>
        [XmlElement("data_time")]
        public string DataTime { get; set; }
    }
}
