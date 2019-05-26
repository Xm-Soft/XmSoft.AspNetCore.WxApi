using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 广告位list ,目前只有一个广告位
        /// </summary>
        [XmlArray("advert_list")]
        [XmlArrayItem("advert")]
        public List<Advert> AdvertList { get; set; }
    }
}
