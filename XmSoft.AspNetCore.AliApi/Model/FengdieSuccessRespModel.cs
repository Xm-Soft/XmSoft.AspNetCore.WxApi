using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FengdieSuccessRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSuccessRespModel : AliApiObject
    {
        /// <summary>
        /// 判断请求操作是否成功，值为 true 或者 false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
