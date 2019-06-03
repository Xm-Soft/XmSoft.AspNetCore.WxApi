using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetFreeCardInfoResponse : WxApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<FreeCardList> list { get; set; }
    }
    public class FreeCardList: DatacubeList
    {
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string card_id { get; set; }
        /// <summary>
        /// cardtype:0：折扣券， 1：代金券，2：礼品券，3：优惠券，4：团购券（暂不支持拉取特殊票券类型数据，电影票、飞机票、会议门票、景区门票）
        /// </summary>
        public int card_type { get; set; }
    }
}
