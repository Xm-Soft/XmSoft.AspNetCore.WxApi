using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Message
{
    /// <summary>
    /// 地理位置消息 - 公众平台
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiLocationNotify : WxApiNotify
    {
        /// <summary>
        /// 地理位置消息 - 公众平台
        /// </summary>
        public WxApiLocationNotify()
        {

        }
        /// <summary>
        ///	地理位置维度
        /// </summary>
        [XmlElement("Location_X")]
        public string Location_X { get; set; }
        /// <summary>
        /// 地理位置经度
        /// </summary>
        [XmlElement("Location_Y")]
      
        public string Location_Y { get; set; }
        /// <summary>
        /// 地图缩放大小
        /// </summary>
        [XmlElement("Scale")]
        public int Scale { get; set; }
        /// <summary>
        /// 地理位置信息
        /// </summary>
        [XmlElement("Label")]
        public string Label { get; set; }
        /// <summary>
        /// 	消息id，64位整型
        /// </summary>
        [XmlElement("MsgId")]

        public int MsgId { get; set; }

    }
}
