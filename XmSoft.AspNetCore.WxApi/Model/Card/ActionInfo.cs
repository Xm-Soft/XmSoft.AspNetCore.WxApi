using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    public class ActionInfo
    {
        /// <summary>
        /// 设置扫描二维码领取单张卡券 单张跟多张 二选一
        /// </summary>
        public CardInfo card { get; set; }
        /// <summary>
        /// 设置扫描二维码领取多张卡券 单张跟多张 二选一
        /// </summary>
        public CardList multiple_card { get; set; }
    }
    public class CardInfo
    {
        /// <summary>
        /// 卡券Code码,use_custom_code字段为true的卡券必须填写，非自定义code和导入code模式的卡券不必填写
        /// </summary>
        public string card_id { get; set; }
        /// <summary>
        /// 卡券ID
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 指定领取者的openid，只有该用户能领取。bind_openid字段为true的卡券必须填写，非指定openid不必填写
        /// </summary>
        public string openid { get; set; }
        /// <summary>
        /// 	指定二维码的有效时间，范围是60 ~ 1800秒。不填默认为365天有效
        /// </summary>
        public int? expire_seconds { get; set; }
        /// <summary>
        /// 	指定下发二维码，生成的二维码随机分配一个code，领取后不可再次扫描。填写true或false。默认false，注意填写该字段时，卡券须通过审核且库存不为0。
        /// </summary>
        public bool? is_unique_code { get; set; }
        /// <summary>
        /// 领取场景值，用于领取渠道的数据统计，默认值为0，字段类型为整型，长度限制为60位数字。用户领取卡券后触发的 事件推送 中会带上此自定义场景值。
        /// </summary>
        public int? outer_id { get; set; }
        /// <summary>
        /// outer_id字段升级版本，字符串类型，用户首次领卡时，会通过 领取事件推送 给商户； 
        /// <para>对于会员卡的二维码，用户每次扫码打开会员卡后点击任何url，会将该值拼入url中，方便开发者定位扫码来源</para>
        /// </summary>
        public string outer_str { get; set; }
    }

  
    public class CardList
    {
       public List<CardInfo> card_list { get; set; }
    }
}
