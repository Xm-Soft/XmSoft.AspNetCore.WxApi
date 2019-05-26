using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTinyappExistQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
