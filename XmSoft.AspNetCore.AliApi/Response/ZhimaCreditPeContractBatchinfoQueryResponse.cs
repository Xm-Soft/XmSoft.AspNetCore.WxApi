using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaCreditPeContractBatchinfoQueryResponse.
    /// </summary>
    public class ZhimaCreditPeContractBatchinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 本批次记录条数
        /// </summary>
        [XmlElement("batch_record")]
        public long BatchRecord { get; set; }

        /// <summary>
        /// 记录数据，通过gzip压缩
        /// </summary>
        [XmlElement("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 数据MD5签名
        /// </summary>
        [XmlElement("md_5_sign")]
        public string Md5Sign { get; set; }

        /// <summary>
        /// 下一个查询批次号
        /// </summary>
        [XmlElement("next_batch_index")]
        public long NextBatchIndex { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_record")]
        public long TotalRecord { get; set; }

        /// <summary>
        /// 查询事务号，包含时间戳因素，只会返回在这个事务号之前创建的相关合约
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
