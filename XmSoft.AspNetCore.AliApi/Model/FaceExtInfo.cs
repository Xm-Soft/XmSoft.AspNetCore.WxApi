using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FaceExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceExtInfo : AliApiObject
    {
        /// <summary>
        /// query_type不填, 返回uid  query_type=1, 返回手机号  query_type=2, 返回图片
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
