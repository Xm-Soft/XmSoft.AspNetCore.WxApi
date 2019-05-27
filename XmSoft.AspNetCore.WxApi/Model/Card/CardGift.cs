using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
   public  class CardGift:Card
    {
        public GiftInfo gift { get; set; }
    }
    public class GiftInfo
    {
        public BaseInfo base_info { get; set; }
        public AdvancedInfo advanced_info { get; set; }
        /// <summary>
        /// 兑换券专用，填写兑换内容的名称。比如：可兑换音乐木盒一个
        /// </summary>
        public string gift { get; set; }
    }
}
