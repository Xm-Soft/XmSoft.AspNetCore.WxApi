using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SettleClause Data Structure.
    /// </summary>
    [Serializable]
    public class SettleClause : AliApiObject
    {
        /// <summary>
        /// 结算金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 结算币种，支持人民币：CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 结算账户id。当结算账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当结算账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当结算账户id类型是loginName时，本参数为用户的支付宝登录号
        /// </summary>
        [XmlElement("settle_account_id")]
        public string SettleAccountId { get; set; }

        /// <summary>
        /// 结算账户id类型。  当settle_account_type 为bankCard时，本参数为cardSerialNo，表示结算账户id是银行卡编号;  当settle_account_type 为alipayBalance时，本参数为userId或者loginName，其中userId表示结算账户id是支付宝唯一用户号，loginName表示结算账户id是支付宝登录号
        /// </summary>
        [XmlElement("settle_account_id_type")]
        public string SettleAccountIdType { get; set; }

        /// <summary>
        /// 结算账户类型。    bankCard: 结算账户为银行卡；  alipayBalance: 结算账户为支付宝余额户
        /// </summary>
        [XmlElement("settle_account_type")]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 结算主体账号。  当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID
        /// </summary>
        [XmlElement("settle_entity_id")]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。  SecondMerchant：结算主体为二级商户
        /// </summary>
        [XmlElement("settle_entity_type")]
        public string SettleEntityType { get; set; }
    }
}
