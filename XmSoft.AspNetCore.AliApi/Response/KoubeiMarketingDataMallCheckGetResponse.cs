using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetResponse : AliApiResponse
    {
        /// <summary>
        /// 返回数据字段
        /// </summary>
        [XmlArray("data_results")]
        [XmlArrayItem("data_sec_check_result")]
        public List<DataSecCheckResult> DataResults { get; set; }
    }
}
