using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainFactoringSupplierCreateModel : AliApiObject
    {
        /// <summary>
        /// 采购商网商银行参与者会员ID
        /// </summary>
        [XmlElement("buyer_ip_id")]
        public string BuyerIpId { get; set; }

        /// <summary>
        /// 采购商网商银行参与者会员角色ID
        /// </summary>
        [XmlElement("buyer_ip_role_id")]
        public string BuyerIpRoleId { get; set; }

        /// <summary>
        /// 采购商会员站点：ALIPAY:支付宝(当前支持)
        /// </summary>
        [XmlElement("buyer_site")]
        public string BuyerSite { get; set; }

        /// <summary>
        /// 采购商支付宝ID
        /// </summary>
        [XmlElement("buyer_site_user_id")]
        public string BuyerSiteUserId { get; set; }

        /// <summary>
        /// 供应商收款银行卡号
        /// </summary>
        [XmlElement("seller_bank_acc")]
        public string SellerBankAcc { get; set; }

        /// <summary>
        /// 供应商收款银行账户名
        /// </summary>
        [XmlElement("seller_bank_acc_name")]
        public string SellerBankAccName { get; set; }

        /// <summary>
        /// 供应商支行联行号-外标(企业时必填)
        /// </summary>
        [XmlElement("seller_bank_branch_union_code")]
        public string SellerBankBranchUnionCode { get; set; }

        /// <summary>
        /// 供应商银行名称
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 供应商联系人邮箱
        /// </summary>
        [XmlElement("seller_contact_email")]
        public string SellerContactEmail { get; set; }

        /// <summary>
        /// 供应商联系人
        /// </summary>
        [XmlElement("seller_contact_name")]
        public string SellerContactName { get; set; }

        /// <summary>
        /// 供应商联系人电话
        /// </summary>
        [XmlElement("seller_contact_phone")]
        public string SellerContactPhone { get; set; }

        /// <summary>
        /// 供应商支付宝会员登录ID
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
