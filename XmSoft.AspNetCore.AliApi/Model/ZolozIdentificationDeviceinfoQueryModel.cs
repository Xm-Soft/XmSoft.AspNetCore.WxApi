using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationDeviceinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 服务端生成的设备码（由我方提供的sdk或JS(H5)生成）
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// apdid_token对应的设备终端类型,根据生成方式来确定。若使用设备指纹SDK生成则填写APP，若用H5生成则填写PC。若不填写，则默认使用APP
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }
    }
}
