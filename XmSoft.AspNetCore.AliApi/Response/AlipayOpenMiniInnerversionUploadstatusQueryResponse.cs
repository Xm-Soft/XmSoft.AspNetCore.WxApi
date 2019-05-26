using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadstatusQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadstatusQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 构建信息
        /// </summary>
        [XmlElement("build_info")]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 构建好的包地址
        /// </summary>
        [XmlElement("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [XmlElement("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [XmlElement("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 创建版本结果
        /// </summary>
        [XmlElement("version_created")]
        public string VersionCreated { get; set; }
    }
}
