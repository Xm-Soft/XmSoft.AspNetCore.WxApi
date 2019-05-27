using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    public class CardGeneralCoupon : Card
    {
        public GeneralCouponInfo general_coupon {get;set;}

    }
    public class GeneralCouponInfo
    {
        public BaseInfo base_info { get; set; }
        public AdvancedInfo advanced_info { get; set; }
        /// <summary>
        /// 优惠券专用，填写优惠详情。
        /// </summary>
        public string default_detail { get; set; }
    }
}
