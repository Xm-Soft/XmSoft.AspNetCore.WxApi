using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayAccountExrateCollectcoreDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateCollectcoreDataSendModel : AliApiObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
