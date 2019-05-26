using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SsdataDataserviceRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskOfflinevarsQueryModel : AliApiObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [XmlElement("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
