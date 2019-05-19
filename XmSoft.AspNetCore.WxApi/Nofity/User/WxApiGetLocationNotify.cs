using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.User
{
    /// <summary>
    /// 获取用户地理位置
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiGetLocationNotify : WxApiNotify
    {
        /// <summary>
        ///获取用户地理位置
        /// </summary>
        public WxApiGetLocationNotify()
        {

        }
        /// <summary>
        /// 	地理位置纬度
        /// </summary>
        [XmlElement("Latitude")]
        public string Latitude { get; set; }
        /// <summary>
        /// 	地理位置经度
        /// </summary>
        [XmlElement("Longitude")]
      
        public string Longitude { get; set; }
        /// <summary>
        /// 地理位置精度
        /// </summary>
        [XmlElement("Precision")]
        public string Precision { get; set; }
       

    }
}
