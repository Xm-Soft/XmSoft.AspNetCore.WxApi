using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertContentShareCodeModify Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShareCodeModify : AliApiObject
    {
        /// <summary>
        /// 宣传展示标题（不能超过30个字符）
        /// </summary>
        [XmlElement("display_title")]
        public string DisplayTitle { get; set; }
    }
}
