using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Message
{
    /// <summary>
    /// 文本消息 - 公众平台
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiTextNotify : WxApiNotify
    {
        /// <summary>
        /// 文本消息 - 公众平台
        /// </summary>
        public WxApiTextNotify()
        {

        }
        /// <summary>
        ///文本消息内容
        /// </summary>
        [XmlElement("Content")]
        public string Content { get; set; }
        /// <summary>
        /// 	消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]
      
        public int MsgId { get; set; }
      

    }
}
