using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ShopBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class ShopBusinessTime : AliApiObject
    {
        /// <summary>
        /// 关门时间 格式：HH:mm
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 开门时间 格式：HH:mm
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 本对象表示周几的营业时间。1~6表示周一到周六，7表示周日
        /// </summary>
        [XmlElement("week_day")]
        public long WeekDay { get; set; }
    }
}
