using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Poi
{
    /// <summary>
    /// 审核事件推送
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiAddPoiNotify : WxApiNotify
    {
        /// <summary>
        ///审核事件推送
        /// </summary>
        public WxApiAddPoiNotify()
        {

        }
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
        /// 消息类型，event
        /// </summary>
        [XmlElement("MsgType")]
        public string MsgType { get; set; }
        /// <summary>
        /// 事件类型，poi_check_notify
        /// </summary>
        [XmlElement("Event")]
        public string Event { get; set; }
        /// <summary>
        /// 商户自己内部ID，即字段中的sid
        /// </summary>
        [XmlElement("UniqId")]
        public string UniqId { get; set; }
        /// <summary>
        /// 微信的门店ID，微信内门店唯一标示ID
        /// </summary>
        [XmlElement("PoiId")]
      
        public string PoiId { get; set; }
        /// <summary>
        /// 审核结果，成功succ 或失败fail
        /// </summary>
        [XmlElement("Result")]
        public string Result { get; set; }
        /// <summary>
        /// 成功的通知信息，或审核失败的驳回理由
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

    }
}
