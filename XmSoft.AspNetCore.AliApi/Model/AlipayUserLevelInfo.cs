using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserLevelInfo : AliApiObject
    {
        /// <summary>
        /// 支付宝用户登陆账号；邮箱优先，手机号次之
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户等级：可选5、4、3、2、1、0；等级5最高，1最低，0标示无法判断
        /// </summary>
        [XmlElement("user_level")]
        public string UserLevel { get; set; }
    }
}
