using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataDataserviceRiskDeviceidentityQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskDeviceidentityQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 盗卡盗账户概率，用于识别账号被盗的风险，数值越大风险概率越大，范围0~1，小数点后保留6有效数
        /// </summary>
        [XmlElement("ato_score")]
        public string AtoScore { get; set; }

        /// <summary>
        /// 身份被冒用概率，用于识别账号被冒用风险，数值越大风险概率越大，范围0~1，小数点后保留6有效数
        /// </summary>
        [XmlElement("fake_score")]
        public string FakeScore { get; set; }

        /// <summary>
        /// 垃圾账户概率，用于识别垃圾账户的风险，数值越大风险概率越大，范围0~1，小数点后保留6有效数
        /// </summary>
        [XmlElement("rub_score")]
        public string RubScore { get; set; }

        /// <summary>
        /// 设备ID，设备的唯一识别号
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// 调用订单号，服务端唯一个识别号
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
