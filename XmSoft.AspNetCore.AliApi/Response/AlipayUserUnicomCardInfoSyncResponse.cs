using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserUnicomCardInfoSyncResponse.
    /// </summary>
    public class AlipayUserUnicomCardInfoSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 业务处理结果 （成功: SUCCESS, 失败: FAIL, 重试: RETRY）
        /// </summary>
        [XmlElement("card_sync_result")]
        public string CardSyncResult { get; set; }

        /// <summary>
        /// 状态发生变更的用户的联通手机号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
