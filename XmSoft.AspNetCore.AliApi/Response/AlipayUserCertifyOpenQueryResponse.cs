using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryResponse.
    /// </summary>
    public class AlipayUserCertifyOpenQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 认证的主体信息，一般的认证场景返回为空
        /// </summary>
        [XmlElement("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空
        /// </summary>
        [XmlElement("material_info")]
        public string MaterialInfo { get; set; }

        /// <summary>
        /// 是否通过，通过为T，不通过为F
        /// </summary>
        [XmlArray("passed")]
        [XmlArrayItem("string")]
        public List<string> Passed { get; set; }
    }
}
