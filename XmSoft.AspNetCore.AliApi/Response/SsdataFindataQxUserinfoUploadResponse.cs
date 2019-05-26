using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataFindataQxUserinfoUploadResponse.
    /// </summary>
    public class SsdataFindataQxUserinfoUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 系统生成的业务唯一标识，用于标识商户的一笔业务
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 返回的表单key值列表，不同的运营商有不同的参数要求  phoneNo：手机号,servicePassword：服务密码,smsCode：短信验证码  capath:图片验证码,name:姓名,certNo:身份证
        /// </summary>
        [XmlArray("form_list")]
        [XmlArrayItem("string")]
        public List<string> FormList { get; set; }

        /// <summary>
        /// 商户业务流水号，如果商户有传入，则原样返回。如果商户没有传入，则有系统生成返回
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }
    }
}
