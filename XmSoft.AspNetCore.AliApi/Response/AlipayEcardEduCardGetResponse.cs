using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcardEduCardGetResponse.
    /// </summary>
    public class AlipayEcardEduCardGetResponse : AliApiResponse
    {
        /// <summary>
        /// 用户是否首次充值标记
        /// </summary>
        [XmlElement("first_deposit_flag")]
        public bool FirstDepositFlag { get; set; }

        /// <summary>
        /// 校园一卡通历史充值卡信息查询结果对象
        /// </summary>
        [XmlArray("onecard")]
        [XmlArrayItem("edu_one_card_deposit_card_query_result")]
        public List<EduOneCardDepositCardQueryResult> Onecard { get; set; }
    }
}
