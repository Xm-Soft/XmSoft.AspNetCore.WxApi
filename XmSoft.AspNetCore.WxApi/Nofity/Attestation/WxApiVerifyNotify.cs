using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Attestation
{
    /// <summary>
    /// 资质认证成功/失败（此时立即获得接口权限）
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiVerifyNotify : WxApiNotify
    {
        /// <summary>
        ///资质认证成功/失败，名称认证，年审通知（此时立即获得接口权限） - 公众平台
        /// </summary>
        public WxApiVerifyNotify()
        {

        }
        /// <summary>
        ///有效期 (整形)，指的是时间戳，将于该时间戳认证过期
        /// </summary>
        [XmlElement("ExpiredTime")]
        public int ExpiredTime { get; set; }
        /// <summary>
        /// 	失败发生时间 (整形)，时间戳
        /// </summary>
        [XmlElement("FailTime")]
      
        public int FailTime { get; set; }
        /// <summary>
        /// 认证失败的原因
        /// </summary>
        [XmlElement("FailReason")]
        public string FailReason { get; set; }
        

        

    }
}
