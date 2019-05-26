using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ArMonthlyBillDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ArMonthlyBillDTO : AliApiObject
    {
        /// <summary>
        /// 出账日
        /// </summary>
        [XmlElement("account_day")]
        public string AccountDay { get; set; }

        /// <summary>
        /// 应收日期(yyyyMMdd)
        /// </summary>
        [XmlElement("accrued_date")]
        public string AccruedDate { get; set; }

        /// <summary>
        /// 调账金额
        /// </summary>
        [XmlElement("adjust_amt")]
        public MultiCurrencyMoneyOpenApi AdjustAmt { get; set; }

        /// <summary>
        /// 分析维度1
        /// </summary>
        [XmlElement("analysis_dmsn_1")]
        public string AnalysisDmsn1 { get; set; }

        /// <summary>
        /// 分析维度2
        /// </summary>
        [XmlElement("analysis_dmsn_2")]
        public string AnalysisDmsn2 { get; set; }

        /// <summary>
        /// 分析维度3
        /// </summary>
        [XmlElement("analysis_dmsn_3")]
        public string AnalysisDmsn3 { get; set; }

        /// <summary>
        /// 分析维度4
        /// </summary>
        [XmlElement("analysis_dmsn_4")]
        public string AnalysisDmsn4 { get; set; }

        /// <summary>
        /// 合约号，商户签约产品对应的合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单金额（原始账单金额，对于月账单存在调整金额的情况，真实账单金额=原始账单金额+调整金额）
        /// </summary>
        [XmlElement("bill_amt")]
        public MultiCurrencyMoneyOpenApi BillAmt { get; set; }

        /// <summary>
        /// 账单结束日期
        /// </summary>
        [XmlElement("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单月
        /// </summary>
        [XmlElement("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 月账单号,唯一标识月账单的ID
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单开始日期
        /// </summary>
        [XmlElement("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 账单类型  21：应收月账单  目前仅支持该类型的账单类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 收费项编码
        /// </summary>
        [XmlElement("charge_item_code")]
        public string ChargeItemCode { get; set; }

        /// <summary>
        /// 计费类型  01：云在线计费，02：离线计费，03：老主站计收费，04：芝麻在线计收费
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 出账状态  01：账单生成，02：待确认出账，03：已出账，04：客户已对账，05：对账差异，06：部分出账
        /// </summary>
        [XmlElement("check_status")]
        public string CheckStatus { get; set; }

        /// <summary>
        /// 已出账金额
        /// </summary>
        [XmlElement("checked_amt")]
        public MultiCurrencyMoneyOpenApi CheckedAmt { get; set; }

        /// <summary>
        /// 出账中金额
        /// </summary>
        [XmlElement("checking_amt")]
        public MultiCurrencyMoneyOpenApi CheckingAmt { get; set; }

        /// <summary>
        /// 计算依据
        /// </summary>
        [XmlElement("clcn_basic_amt")]
        public long ClcnBasicAmt { get; set; }

        /// <summary>
        /// 计算依据类型  01：交易金额，02：交易笔数，03：交易张数，04：资费依据扩展，05：其他
        /// </summary>
        [XmlElement("clcn_basic_type")]
        public string ClcnBasicType { get; set; }

        /// <summary>
        /// 计算方法  01：差额累进，02：全额累进，03：按传入金额收费，04：价格包量，05：包时间周期，06：按时间全额累进，07：包时间周期差额累进，08：期间差额累进，09：期间全额累进，10：包时间周期单笔，11：标准单笔计费，12：包时间周期单笔-按照传入金额计费，13：期间靠档差额累进，靠档计息使用，14：自定义
        /// </summary>
        [XmlElement("clcn_method")]
        public string ClcnMethod { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("freeze_amt")]
        public MultiCurrencyMoneyOpenApi FreezeAmt { get; set; }

        /// <summary>
        /// 创建时间（创建备份时需要）
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间（创建备份时需要）
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 分支机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [XmlElement("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 结算对象参与者标识
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 参与者名字
        /// </summary>
        [XmlElement("ip_name")]
        public string IpName { get; set; }

        /// <summary>
        /// 结算对象参与者角色标识
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [XmlElement("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 付款来源  1：主账务，2：包量，3：预收，4：预存，5：银行，6：积分，7：统一支付，8：支付受理
        /// </summary>
        [XmlElement("pay_original")]
        public string PayOriginal { get; set; }

        /// <summary>
        /// 付款状态  01：待结算；02：部分结算；03：结算完成
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 付款方式  1：资金；2：包量
        /// </summary>
        [XmlElement("pay_way")]
        public string PayWay { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [XmlElement("payer_account")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// 扣款对象pid
        /// </summary>
        [XmlElement("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 已收金额
        /// </summary>
        [XmlElement("received_amt")]
        public MultiCurrencyMoneyOpenApi ReceivedAmt { get; set; }

        /// <summary>
        /// 记录id，账单全局唯一号
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 服务金额
        /// </summary>
        [XmlElement("service_amt")]
        public MultiCurrencyMoneyOpenApi ServiceAmt { get; set; }

        /// <summary>
        /// 结算类型  01：实时；02：预收；03：后收；04：周期结算；05：按日汇总结算；09：延期结算
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 签约对象参与者标识
        /// </summary>
        [XmlElement("sign_ip_id")]
        public string SignIpId { get; set; }

        /// <summary>
        /// 签约对象参与者角色标识
        /// </summary>
        [XmlElement("sign_ip_role_id")]
        public string SignIpRoleId { get; set; }

        /// <summary>
        /// 结算对象PID
        /// </summary>
        [XmlElement("stl_ip_role_id")]
        public string StlIpRoleId { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 税收类型，01：增值税，02：营业税  营业税已经在大部分行业废弃，要传入需咨询后再确认
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 待核销明细数量
        /// </summary>
        [XmlElement("to_writeoff_detail_count")]
        public long ToWriteoffDetailCount { get; set; }

        /// <summary>
        /// 账单分类 1应收，2返点
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 核销明细数量
        /// </summary>
        [XmlElement("writeoff_detail_dount")]
        public long WriteoffDetailDount { get; set; }

        /// <summary>
        /// 核销中金额
        /// </summary>
        [XmlElement("writingoff_amt")]
        public MultiCurrencyMoneyOpenApi WritingoffAmt { get; set; }
    }
}
