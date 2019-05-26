using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// TableListResult Data Structure.
    /// </summary>
    [Serializable]
    public class TableListResult : AliApiObject
    {
        /// <summary>
        /// 桌名
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }
    }
}
