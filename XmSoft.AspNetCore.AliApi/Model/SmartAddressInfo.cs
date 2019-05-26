using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SmartAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAddressInfo : AliApiObject
    {
        /// <summary>
        /// 行政区代码-区，使用国家行政区划代码，可参考http://preview.www.mca.gov.cn/article/sj/xzqh/2018/201805/20180506280855.html
        /// </summary>
        [XmlElement("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 行政区代码-市，使用国家行政区划代码，可参考http://preview.www.mca.gov.cn/article/sj/xzqh/2018/201805/20180506280855.html
        /// </summary>
        [XmlElement("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 自助售货机地址
        /// </summary>
        [XmlElement("machine_address")]
        public string MachineAddress { get; set; }

        /// <summary>
        /// 行政区代码-省，使用国家行政区划代码，可参考http://preview.www.mca.gov.cn/article/sj/xzqh/2018/201805/20180506280855.html
        /// </summary>
        [XmlElement("province_code")]
        public long ProvinceCode { get; set; }
    }
}
