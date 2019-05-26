using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCodeRecoResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCodeRecoResult : AliApiObject
    {
        /// <summary>
        /// 识别的验证码内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
