using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsUnderwriteUserPolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteUserPolicyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询到的用户拥有的保单列表，含所有查询状态对应的保单，排序规则按照，保险保障开始时间倒序
        /// </summary>
        [XmlArray("policys")]
        [XmlArrayItem("ins_policy")]
        public List<InsPolicy> Policys { get; set; }

        /// <summary>
        /// 结果的总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
