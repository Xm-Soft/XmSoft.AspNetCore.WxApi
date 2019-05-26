using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// BillDingBizOrder Data Structure.
    /// </summary>
    [Serializable]
    public class BillDingBizOrder : AliApiObject
    {
        /// <summary>
        /// 收支金额,收入为正,支出为负
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 钉钉业务单据号
        /// </summary>
        [XmlElement("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 业务类型标识。支持类型有：0100-群收款，0101-报销，0102-支付，0103-收款，0104-转账，0105-工资
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 资金流向。S表示收入，B表示支出
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 付款完成时间
        /// </summary>
        [XmlElement("gmt_finish")]
        public string GmtFinish { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 脱敏后的对方支付宝账号
        /// </summary>
        [XmlElement("opp_login_id")]
        public string OppLoginId { get; set; }

        /// <summary>
        /// 对方昵称
        /// </summary>
        [XmlElement("opp_nick_name")]
        public string OppNickName { get; set; }

        /// <summary>
        /// 对方姓名
        /// </summary>
        [XmlElement("opp_user_name")]
        public string OppUserName { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 业务类型, 有合作伙伴进行业务处理是传入,这里再透传回去
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
