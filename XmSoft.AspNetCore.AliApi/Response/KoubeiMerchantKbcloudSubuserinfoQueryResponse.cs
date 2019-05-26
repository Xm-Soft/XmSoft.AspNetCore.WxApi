using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑子账号数据列表
        /// </summary>
        [XmlArray("sub_cloud_user_list")]
        [XmlArrayItem("sub_cloud_user_info")]
        public List<SubCloudUserInfo> SubCloudUserList { get; set; }
    }
}
