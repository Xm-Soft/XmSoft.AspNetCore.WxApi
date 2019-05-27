using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SsdataFindatAliApieratorSmsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindatAliApieratorSmsQueryModel : AliApiObject
    {
        /// <summary>
        /// 系统的业务流水号，在调用提交用户信息时得到的biz_no
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
