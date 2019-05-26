using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailInstanceTransferResponse.
    /// </summary>
    public class KoubeiRetailInstanceTransferResponse : AliApiResponse
    {
        /// <summary>
        /// 请求的id信息
        /// </summary>
        [XmlArray("instance_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstanceIdList { get; set; }
    }
}
