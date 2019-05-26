using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppNotifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppNotifyVerifyModel : AliApiObject
    {
        /// <summary>
        /// 通知id
        /// </summary>
        [XmlElement("notify_id")]
        public string NotifyId { get; set; }
    }
}
