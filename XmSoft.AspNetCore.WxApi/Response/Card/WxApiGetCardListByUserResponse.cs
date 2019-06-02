using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetCardListByUserResponse : WxApiResponse
    {
        public List<CardList> card_list { get; set; }
        /// <summary>
        /// 卡券ID。
        /// </summary>
        public bool has_share_card { get; set; }
      
    }
    public class CardList
    {
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string card_id { get; set; }
        /// <summary>
        /// 需核销的Code码。
        /// </summary>
        public string code { get; set; }
       
    }
}
