using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetCardMembercCardInfoResponse : WxApiResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        public List<MmberCardList> list { get; set; }
    }
    public class MmberCardList
    {
        /// <summary>
        /// 	日期信息
        /// </summary>
        public string ref_date { get; set; }
        /// <summary>
        /// 	浏览次数
        /// </summary>
        public int view_cnt { get; set; }
        /// <summary>
        /// 浏览人数
        /// </summary>
        public int view_user { get; set; }
        /// <summary>
        /// 领取次数
        /// </summary>
        public int receive_cnt { get; set; }
        /// <summary>
        /// 领取人数
        /// </summary>
        public int receive_user { get; set; }
        /// <summary>
        /// 	使用次数
        /// </summary>
        public int verify_cnt { get; set; }
        /// <summary>
        /// 使用人数
        /// </summary>
        public int verify_user { get; set; }

        /// <summary>
        /// 有效会员总人数
        /// </summary>
        public int total_user { get; set; }
        /// <summary>
        /// 历史领取会员卡总人数
        /// </summary>
        public int total_receive_user { get; set; }
    }
        
}
