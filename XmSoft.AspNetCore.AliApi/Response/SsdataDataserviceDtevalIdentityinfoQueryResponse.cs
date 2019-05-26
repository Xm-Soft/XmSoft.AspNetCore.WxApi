using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataDataserviceDtevalIdentityinfoQueryResponse.
    /// </summary>
    public class SsdataDataserviceDtevalIdentityinfoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回消息描述(description)，代表查询的信息，如果status=false时候，该值会对没有查询到的情况进行解释
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 身份证号码(id_card_no)，代表查询到的用户身份证号码，该值由dteval实现的处理器处理后返回，但是前提是status=true
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 手机号(phone)，代表用户传入的值，系统不做处理，直接原样返回，代表该笔业务的一个凭证信息
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 状态(status)，代表匹配结果，如果是true，代表通过手机号查询到了身份信息，即三要素(姓名，身份证号码，手机号)信息，如果是false，代表没有查询到
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户姓名(user_name)，代表查询到的用户姓名，该值由dteval实现的处理器处理后返回，但是前提是status=true
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
