using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySocialGiftStockUploadResponse.
    /// </summary>
    public class AlipaySocialGiftStockUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 重复条数
        /// </summary>
        [XmlElement("duplicate_count")]
        public long DuplicateCount { get; set; }

        /// <summary>
        /// 失败条数
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 成功条数
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
