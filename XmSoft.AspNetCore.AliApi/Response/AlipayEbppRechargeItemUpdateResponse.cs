using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppRechargeItemUpdateResponse.
    /// </summary>
    public class AlipayEbppRechargeItemUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 返回对象的列表
        /// </summary>
        [XmlArray("iterm_infos")]
        [XmlArrayItem("iterm_info")]
        public List<ItermInfo> ItermInfos { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
