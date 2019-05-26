using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenMiniPayeeUnbindResponse.
    /// </summary>
    public class AlipayOpenMiniPayeeUnbindResponse : AliApiResponse
    {
        /// <summary>
        /// 解绑结果，true解绑成功，false解绑失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
