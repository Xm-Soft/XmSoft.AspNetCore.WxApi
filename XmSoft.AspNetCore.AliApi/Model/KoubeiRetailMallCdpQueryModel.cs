using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailMallCdpQueryModel : AliApiObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
