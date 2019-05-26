using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDatabizCoreUserLevelGetResponse.
    /// </summary>
    public class AlipayDatabizCoreUserLevelGetResponse : AliApiResponse
    {
        /// <summary>
        /// 支付宝用户等级信息
        /// </summary>
        [XmlArray("user_level_infos")]
        [XmlArrayItem("alipay_user_level_info")]
        public List<AlipayUserLevelInfo> UserLevelInfos { get; set; }
    }
}
