using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppLingqierwuLingqierquQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLingqierwuLingqierquQueryModel : AliApiObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("string")]
        public List<string> Test { get; set; }
    }
}
