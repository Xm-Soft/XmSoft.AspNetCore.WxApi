using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringDishDictionarySyncResponse.
    /// </summary>
    public class KoubeiCateringDishDictionarySyncResponse : AliApiResponse
    {
        /// <summary>
        /// 字典的数据id
        /// </summary>
        [XmlElement("dictionary_id")]
        public string DictionaryId { get; set; }
    }
}
