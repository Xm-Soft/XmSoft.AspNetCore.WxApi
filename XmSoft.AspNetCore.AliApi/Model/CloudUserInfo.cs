using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// CloudUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudUserInfo : AliApiObject
    {
        /// <summary>
        /// 口碑主账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑主账号名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
