using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbAdvertDealBillResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertDealBillResponse : AliApiObject
    {
        /// <summary>
        /// 账单下载地址(为空表示查无账单)
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }
    }
}
