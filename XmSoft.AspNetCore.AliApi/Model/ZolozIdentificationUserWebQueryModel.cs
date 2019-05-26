using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationUserWebQueryModel : AliApiObject
    {
        /// <summary>
        /// 商户请求的唯一标识，须与初始化传入的bizId保持一致
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extern_param")]
        public string ExternParam { get; set; }

        /// <summary>
        /// 刷脸认证的唯一标识，用于查询认证结果
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
