using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertPurchaseResponse.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertPurchaseResponse : AliApiResponse
    {
        /// <summary>
        /// 主键Code结果，采购请求是批量形式的，每个identify，对应一个处理结果
        /// </summary>
        [XmlArray("identify_codes")]
        [XmlArrayItem("kb_advert_identify_response")]
        public List<KbAdvertIdentifyResponse> IdentifyCodes { get; set; }
    }
}
