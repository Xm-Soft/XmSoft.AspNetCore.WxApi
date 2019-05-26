using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BusinessLicenseCertFileds Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenseCertFileds : AliApiObject
    {
        /// <summary>
        /// 社会信用代码
        /// </summary>
        [XmlElement("creditcode")]
        public string Creditcode { get; set; }

        /// <summary>
        /// 公司名字
        /// </summary>
        [XmlElement("entname")]
        public string Entname { get; set; }
    }
}
