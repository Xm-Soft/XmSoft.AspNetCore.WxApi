using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoSecuritydataQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoSecuritydataQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 查询结果,  结果为json格式  返回值的key, 为入参查询值的主体.  返回值的value, 为入参查询值的结果.以风控黑名单为例,在黑名单中返回"hasRisk",不在黑名单中返回"noRisk".
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
