using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsDataWeatherSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataWeatherSyncModel : AliApiObject
    {
        /// <summary>
        /// 天气信息描述信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部业务幂等字段
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
