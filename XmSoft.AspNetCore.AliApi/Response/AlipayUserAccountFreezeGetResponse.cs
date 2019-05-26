using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAccountFreezeGetResponse.
    /// </summary>
    public class AlipayUserAccountFreezeGetResponse : AliApiResponse
    {
        /// <summary>
        /// 冻结金额列表
        /// </summary>
        [XmlArray("freeze_items")]
        [XmlArrayItem("account_freeze")]
        public List<AccountFreeze> FreezeItems { get; set; }

        /// <summary>
        /// 冻结总条数
        /// </summary>
        [XmlElement("total_results")]
        public string TotalResults { get; set; }
    }
}
