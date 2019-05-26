using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSmsgDataSetModel : AliApiObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [XmlElement("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
