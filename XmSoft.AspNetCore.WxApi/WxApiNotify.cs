using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 回调的基层信息。
    /// </summary>
    public abstract class WxApiNotify:WxApiXmlObject
    {
        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary>
        [XmlElement("ToUserName")]
        public string ToUserName { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("FromUserName")]
        public string FromUserName { get; set; }
        /// <summary>
        /// 消息创建时间（整型）
        /// </summary>
        [XmlElement("CreateTime")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("MsgType")]
        public string MsgType { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("Event")]
        public string Event { get; set; }
    }
}
