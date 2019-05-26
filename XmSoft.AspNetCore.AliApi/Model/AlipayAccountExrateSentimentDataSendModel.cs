using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateSentimentDataSendModel : AliApiObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
