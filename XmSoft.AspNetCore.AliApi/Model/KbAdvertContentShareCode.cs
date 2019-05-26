using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertContentShareCode Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShareCode : AliApiObject
    {
        /// <summary>
        /// 吱口令内容详情
        /// </summary>
        [XmlElement("share_code_desc")]
        public string ShareCodeDesc { get; set; }
    }
}
