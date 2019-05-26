using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SignTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class SignTaskResult : AliApiObject
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝签约入口地址
        /// </summary>
        [XmlElement("sign_enter_url")]
        public string SignEnterUrl { get; set; }

        /// <summary>
        /// 签名任务流水号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
