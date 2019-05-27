using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    /// <summary>
    /// 团购类型卡券
    /// </summary>
    public class CardGroupon:Card
    {
        /// <summary>
        /// 团购
        /// </summary>
        public GrouponInfo groupon { get; set; }
    }
    public class GrouponInfo
    {
        public BaseInfo base_info { get; set; }
        public AdvancedInfo advanced_info { get; set; }
        public string deal_detail { get; set; }
    }
}
