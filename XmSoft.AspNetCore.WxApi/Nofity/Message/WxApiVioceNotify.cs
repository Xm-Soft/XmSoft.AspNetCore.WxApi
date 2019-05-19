using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Message
{
    /// <summary>
    /// 语音消息 - 公众平台
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiVioceNotify : WxApiNotify
    {
        /// <summary>
        /// 语音消息 - 公众平台
        /// </summary>
        public WxApiVioceNotify()
        {

        }
        /// <summary>
        ///语音格式，如amr，speex等
        /// </summary>
        [XmlElement("Format")]
        public string Format { get; set; }
        /// <summary>
        /// 	语音消息媒体id，可以调用获取临时素材接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
      
        public string MediaId { get; set; }
        /// <summary>
        /// 	消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]

        public int MsgId { get; set; }
        /// <summary>
        /// 语音识别结果，UTF8编码
        /// </summary>
        public string Recognition { get; set; }

    }
}
