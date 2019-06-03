﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetCardMemberCardDetailResponse : WxApiResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        public List<MmberCardDetailList> list { get; set; }
    }
    public class MmberCardDetailList
    {
        /// <summary>
        /// 	日期信息
        /// </summary>
        public string ref_date { get; set; }
        public int merchanttype { get; set; }
        public string cardid { get; set; }
        public int submerchantid { get; set; }
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
        /// 激活人数
        /// </summary>
        public int active_cnt { get; set; }
        /// <summary>
        /// 激活人数
        /// </summary>
        public int active_user { get; set; }
        /// <summary>
        /// 有效会员总人数
        /// </summary>
        public int total_user { get; set; }
        /// <summary>
        /// 历史领取会员卡总人数
        /// </summary>
        public int total_receive_user { get; set; }
        /// <summary>
        /// 	新用户数
        /// </summary>
        public int new_user { get; set; }
        /// <summary>
        /// 应收金额（仅限使用快速买单的会员卡）
        /// </summary>
        public int payOriginalFee { get; set; }
        /// <summary>
        /// 实收金额（仅限使用快速买单的会员卡）
        /// </summary>
        public int fee { get; set; }
    }
        
}
