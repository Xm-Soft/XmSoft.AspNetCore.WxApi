using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsAutoCarSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoCarSaveModel : AliApiObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 用户ID,车主会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
