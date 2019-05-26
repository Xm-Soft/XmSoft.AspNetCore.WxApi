using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FaceAbilityExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceAbilityExtInfo : AliApiObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 证件号信息
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号信息
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 比对源渠道信息
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 人脸加密后的特征
        /// </summary>
        [XmlElement("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 是否存在攻击
        /// </summary>
        [XmlElement("hasrisk")]
        public string Hasrisk { get; set; }

        /// <summary>
        /// 质量分
        /// </summary>
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 特征矩形区域"442,231,412,262"
        /// </summary>
        [XmlElement("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 男女
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 活体源，customer：业务方自定义采集；alisp:支付宝小程序
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
