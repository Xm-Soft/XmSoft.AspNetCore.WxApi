using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ArrangementNoQuerier Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementNoQuerier : AliApiObject
    {
        /// <summary>
        /// 合约编号列表
        /// </summary>
        [XmlArray("ar_nos")]
        [XmlArrayItem("string")]
        public List<string> ArNos { get; set; }
    }
}
