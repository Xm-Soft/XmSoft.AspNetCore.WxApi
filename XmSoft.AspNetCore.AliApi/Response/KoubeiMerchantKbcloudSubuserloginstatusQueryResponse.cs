using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserloginstatusQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserloginstatusQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑云登录的子账号信息；如果未登录则返回null
        /// </summary>
        [XmlElement("user_login_status")]
        public UserLoginStatusDetail UserLoginStatus { get; set; }
    }
}
