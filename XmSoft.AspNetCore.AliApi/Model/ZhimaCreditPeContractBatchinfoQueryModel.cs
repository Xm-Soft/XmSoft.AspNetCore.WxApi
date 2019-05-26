using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeContractBatchinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractBatchinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 查询批次号，从1开始计数
        /// </summary>
        [XmlElement("batch_index")]
        public long BatchIndex { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 批量查询数据日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 查询事务号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
