using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeProvcityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeProvcityQueryModel : AliApiObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [XmlElement("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 查询类型，queryType=1,查询省下面的市信息
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
