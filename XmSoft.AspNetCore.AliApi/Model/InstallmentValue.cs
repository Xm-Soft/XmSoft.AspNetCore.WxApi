using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// InstallmentValue Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentValue : AliApiObject
    {
        /// <summary>
        /// 分段值
        /// </summary>
        [XmlArray("installment_values")]
        [XmlArrayItem("installment_meta_info")]
        public List<InstallmentMetaInfo> InstallmentValues { get; set; }
    }
}
