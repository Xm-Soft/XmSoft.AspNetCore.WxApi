using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CityFunction Data Structure.
    /// </summary>
    [Serializable]
    public class CityFunction : AliApiObject
    {
        /// <summary>
        /// 城市标准编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 描述功能，支持开卡(issue)，圈存(load)，充值转账(recharge)
        /// </summary>
        [XmlArray("function_type")]
        [XmlArrayItem("string")]
        public List<string> FunctionType { get; set; }
    }
}
