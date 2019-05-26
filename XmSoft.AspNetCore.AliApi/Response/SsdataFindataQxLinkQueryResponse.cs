using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataFindataQxLinkQueryResponse.
    /// </summary>
    public class SsdataFindataQxLinkQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 系统生成的业务唯一标识，用于标识商户的一笔业务
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户业务流水号，如果商户有传入，则原样返回。如果商户没有传入，则有系统生成返回
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 返回的url地址  http://bd.openapi.shulidata.com/gateway.do?api=slops.authcoll.channel.page&bizContent=B2oqkKrdw299TSHGfdDDUnMuLVSz4b%2FgRDjCrYaRuHJwDTCR9PFdI%2B4p%2BvZXDP%2FK%2BmktLmSDWbXxluVzTSDKu1Mqf8UxAltYrWuG757lJCi5SnU0296h2SQR56YP%2FiQD&bizType=123&charset=UTF-8&encKey=KQ4WfsIexjNavPFanUNasHVH1hda01B3vkRlIk6FXhDSJb0m7ppw7%2BDrfKQ6ORxlGnwu42QK2wTITd651mt5OQ%3D%3D&encType=AES&orgCode=sl2016112510103701&sdkVersion=1.4&sign=0GskfR11zs3A1Sda2apsyN8SjOq6nSijMJsa4UPefXnXMN6F%2FUwBQnARJCA6mdjoyrYF%2FYlgQNw4PtXBECmH%2FzWLbiF2Ap0551z7kklA0mnmHPXTQERLqpkE5eOcozFzEq5zhni3luVIGNoaMXNi7d12SeKtArP24v5kpmUrnMo%3D&signType=RSA&timestamp=1507515730325&version=1.0
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
