using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeUserSceneConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserSceneConsultModel : AliApiObject
    {
        /// <summary>
        /// 买家的蚂蚁统一会员ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 芝麻信用类目码，由芝麻信用侧分配
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 芝麻信用场景，由芝麻信用侧分配，如：天猫信用购，淘宝租赁等
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 业务扩展参数，json格式字符串，如果有需要，请提前联系开发人员沟通确定参数
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 风险环境参数信息，json格式字符串，目前已知key如下：umid，设备指纹；imei，设备号；lbs，经纬度；ip，设备网络IP地址；wireless_mac，设备无线wifi mac；mac，设备网卡地址
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }
    }
}
