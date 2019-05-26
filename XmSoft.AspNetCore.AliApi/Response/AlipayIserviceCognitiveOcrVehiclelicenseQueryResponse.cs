using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehiclelicenseQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehiclelicenseQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 发动机号码
        /// </summary>
        [XmlElement("engine_num")]
        public string EngineNum { get; set; }

        /// <summary>
        /// 识别错误的详细原因描述
        /// </summary>
        [XmlElement("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 发证时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 所有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 号牌号码
        /// </summary>
        [XmlElement("plate_num")]
        public string PlateNum { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 服务器内部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true:识别成功  false:识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 使用性质
        /// </summary>
        [XmlElement("use_character")]
        public string UseCharacter { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别代号
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
