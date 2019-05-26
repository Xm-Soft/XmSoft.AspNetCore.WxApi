using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayAccountExrateAdviceAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateAdviceAcceptModel : AliApiObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [XmlElement("advice")]
        public AdviceVO Advice { get; set; }
    }
}
