using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// DataSendBusinessResult Data Structure.
    /// </summary>
    [Serializable]
    public class DataSendBusinessResult : AliApiObject
    {
        /// <summary>
        /// 数据发送业务处理结果码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 数据发送业务处理结果描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
