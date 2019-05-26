using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PintuanUserInfos Data Structure.
    /// </summary>
    [Serializable]
    public class PintuanUserInfos : AliApiObject
    {
        /// <summary>
        /// 拼团用户信息列表
        /// </summary>
        [XmlElement("pintuan_user_info_list")]
        public PintuanUserInfo PintuanUserInfoList { get; set; }
    }
}
