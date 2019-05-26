using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SubCertDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SubCertDetail : AliApiObject
    {
        /// <summary>
        /// 凭证批次号
        /// </summary>
        [XmlElement("lot_num")]
        public string LotNum { get; set; }

        /// <summary>
        /// 子凭证有效点数
        /// </summary>
        [XmlElement("lot_point")]
        public string LotPoint { get; set; }

        /// <summary>
        /// 子凭证编号
        /// </summary>
        [XmlElement("sub_lotnum")]
        public string SubLotnum { get; set; }
    }
}
