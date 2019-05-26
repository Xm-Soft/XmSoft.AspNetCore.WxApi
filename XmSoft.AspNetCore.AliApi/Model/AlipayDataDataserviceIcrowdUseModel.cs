using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceIcrowdUseModel : AliApiObject
    {
        /// <summary>
        /// icrowd接口请求参数＋唯一不可空
        /// </summary>
        [XmlElement("icrowd_use_param")]
        public IcrowdUseParam IcrowdUseParam { get; set; }
    }
}
