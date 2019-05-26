using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AiOcrTableRow Data Structure.
    /// </summary>
    [Serializable]
    public class AiOcrTableRow : AliApiObject
    {
        /// <summary>
        /// table一行的内容
        /// </summary>
        [XmlArray("row")]
        [XmlArrayItem("ai_ocr_table_context")]
        public List<AiOcrTableContext> Row { get; set; }
    }
}
