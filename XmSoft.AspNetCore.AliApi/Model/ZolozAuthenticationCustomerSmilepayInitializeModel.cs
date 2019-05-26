using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmilepayInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerSmilepayInitializeModel : AliApiObject
    {
        /// <summary>
        /// { "apdidToken": "设备指纹", "appName": "应用名称", "appVersion": "应用版本", "bioMetaInfo": "生物信息如2.3.0:3,-4" }
        /// </summary>
        [XmlElement("zimmetainfo")]
        public string Zimmetainfo { get; set; }
    }
}
