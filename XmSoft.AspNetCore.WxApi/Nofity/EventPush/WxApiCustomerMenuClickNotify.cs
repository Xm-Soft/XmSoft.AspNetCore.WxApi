using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.EventPush
{
    /// <summary>
    /// 用户点击自定义菜单后，微信会把点击事件推送给开发者，请注意，点击菜单弹出子菜单，不会产生上报。
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiCustomerMenuClickNotify : WxApiNotify
    {
        /// <summary>
        /// 点击菜单拉取消息时的事件推送
        /// <para>用户点击自定义菜单后，微信会把点击事件推送给开发者，请注意，点击菜单弹出子菜单，不会产生上报。</para>
        /// </summary>
        public WxApiCustomerMenuClickNotify()
        {

        }
        /// <summary>
        ///事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        [XmlElement("EventKey")]
        public string EventKey { get; set; }
     
     

    }
}
