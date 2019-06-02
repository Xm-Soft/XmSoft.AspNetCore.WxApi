using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetCodeResponse : WxApiResponse
    {
        public Card card { get; set; }
        /// <summary>
        /// 卡券ID。
        /// </summary>
        public string openid { get; set; }
        /// <summary>
        /// 卡券领取时商户传入的渠道值
        /// </summary>
        public string outer_str { get; set; }
        /// <summary>
        /// 是否可以核销，true为可以核销，false为不可核销
        /// </summary>
        public bool can_consume { get; set; }
        /// <summary>
        /// 当前code对应卡券的状态 NORMAL 正常 CONSUMED 已核销 EXPIRE 已过期 GIFTING 转赠中 
        /// GIFT_TIMEOUT 转赠超时 DELETE 已删除 UNAVAILABLE 已失效 code未被添加或被转赠领取的情况则统一报错：invalid serial code
        /// </summary>
        public string user_card_status { get; set; }
    }
    public class Card
    {
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string card_id { get; set; }
        /// <summary>
        /// 起始使用时间
        /// </summary>
        public int begin_time { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public int end_time { get; set; }
    }
}
