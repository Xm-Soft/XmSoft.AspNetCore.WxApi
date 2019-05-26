using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// IcrowdUseResp Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseResp : AliApiObject
    {
        /// <summary>
        /// 方法ID
        /// </summary>
        [XmlElement("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// 方法返回结果
        /// </summary>
        [XmlElement("ret_val")]
        public string RetVal { get; set; }
    }
}
