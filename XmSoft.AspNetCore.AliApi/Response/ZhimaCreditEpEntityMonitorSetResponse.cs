using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetResponse.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorSetResponse : AliApiResponse
    {
        /// <summary>
        /// 添加成功返回true, 失败返回false
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
