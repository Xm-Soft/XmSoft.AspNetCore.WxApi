using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorBatchDeleteResponse.
    /// </summary>
    public class KoubeiMerchantOperatorBatchDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 批量删除，不保证事务，可能有部分成功，部分失败;  枚举值为： PART_SUCCESS, ALL_SUCCESS
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// true, false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
