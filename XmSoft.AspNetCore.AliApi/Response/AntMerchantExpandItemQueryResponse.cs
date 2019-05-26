using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandItemQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_model")]
        public List<ItemModel> ItemList { get; set; }
    }
}
