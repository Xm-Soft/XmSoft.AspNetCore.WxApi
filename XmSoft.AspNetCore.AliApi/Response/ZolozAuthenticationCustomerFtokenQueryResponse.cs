using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenQueryResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFtokenQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 图片base64 encodeString
        /// </summary>
        [XmlElement("authimg_base_64")]
        public string AuthimgBase64 { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户名和手机号信息返回的列表
        /// </summary>
        [XmlArray("uid_tel_pair_list")]
        [XmlArrayItem("zhub_uid_tel_pair")]
        public List<ZhubUidTelPair> UidTelPairList { get; set; }
    }
}
