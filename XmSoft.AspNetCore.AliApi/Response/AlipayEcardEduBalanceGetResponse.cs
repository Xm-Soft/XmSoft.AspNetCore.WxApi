using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcardEduBalanceGetResponse.
    /// </summary>
    public class AlipayEcardEduBalanceGetResponse : AliApiResponse
    {
        /// <summary>
        /// 校园一卡通余额查询结果对象
        /// </summary>
        [XmlArray("balance")]
        [XmlArrayItem("edu_one_card_balance_query_result")]
        public List<EduOneCardBalanceQueryResult> Balance { get; set; }
    }
}
