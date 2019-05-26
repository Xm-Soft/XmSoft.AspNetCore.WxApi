using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// QRcode Data Structure.
    /// </summary>
    [Serializable]
    public class QRcode : AliApiObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// qrcode地址
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
