using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.EventPush
{
    /// <summary>
    /// 扫描带参数二维码事件
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiScanNotify : WxApiNotify
    {
        /// <summary>
        /// 扫描带参数二维码事件 - 公众平台
        /// <para>1、用户未关注时，进行关注后的事件推送 Event : subscribe</para>
        /// <para>2. 用户已关注时的事件推送 Event: SCAN</para>
        /// </summary>
        public WxApiScanNotify()
        {

        }
        /// <summary>
        ///事件KEY值，qrscene_为前缀，后面为二维码的参数值
        /// </summary>
        [XmlElement("EventKey")]
        public string EventKey { get; set; }
        /// <summary>
        /// 	二维码的ticket，可用来换取二维码图片
        /// </summary>
        [XmlElement("Ticket")]
      
        public string Ticket { get; set; }
     

    }
}
