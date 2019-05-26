using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AliApiObject
    {
        /// <summary>
        /// 供应商回传码物料码值记录（最多200条）
        /// </summary>
        [XmlArray("return_qrcodes")]
        [XmlArrayItem("access_return_qrcode")]
        public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
    }
}
