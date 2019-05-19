using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Message
{
    /// <summary>
    /// 视频/小视频 消息 - 公众平台
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiVideoNotify : WxApiNotify
    {
        /// <summary>
        /// 视频消息 - 公众平台
        /// </summary>
        public WxApiVideoNotify()
        {

        }
        /// <summary>
        //视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("ThumbMediaId")]
        public string ThumbMediaId { get; set; }
        /// <summary>
        /// 	视频消息媒体id，可以调用获取临时素材接口拉取数据。
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
