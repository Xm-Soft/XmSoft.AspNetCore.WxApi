using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// NewsfeedWithMeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedWithMeInfo : AliApiObject
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
