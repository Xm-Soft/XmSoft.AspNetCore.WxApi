using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneSellerActivityQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerActivityQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 关于签约查询结果的告知
        /// </summary>
        [XmlElement("ins_seller_activity")]
        public InsSellerActivity InsSellerActivity { get; set; }
    }
}
