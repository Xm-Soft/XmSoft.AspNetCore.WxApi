using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAccountUseridBatchqueryResponse.
    /// </summary>
    public class AlipayUserAccountUseridBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
