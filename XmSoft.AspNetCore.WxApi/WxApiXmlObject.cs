using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 回调基础对象
    /// </summary>
    public class WxApiXmlObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public WxApiDictionary Parameters { get; internal set; }
    }
}
