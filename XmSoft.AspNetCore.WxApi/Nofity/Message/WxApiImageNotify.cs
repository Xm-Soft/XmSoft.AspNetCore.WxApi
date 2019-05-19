using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Message
{
    /// <summary>
    /// 图片消息 - 公众平台
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiImageNotify : WxApiNotify
    {
        /// <summary>
        /// 图片消息 - 公众平台
        /// </summary>
        public WxApiImageNotify()
        {

        }
        /// <summary>
        ///图片链接（由系统生成）
        /// </summary>
        [XmlElement("PicUrl")]
        public string PicUrl { get; set; }
        /// <summary>
        /// 	图片消息媒体id，可以调用获取临时素材接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
      
        public string MediaId { get; set; }
        /// <summary>
        /// 	消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]

        public int MsgId { get; set; }

    }
}
