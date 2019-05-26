using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailTopinstanceQueryModel : AliApiObject
    {
        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM）
        /// </summary>
        [XmlElement("instance_type")]
        public string InstanceType { get; set; }
    }
}
