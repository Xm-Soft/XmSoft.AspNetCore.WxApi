using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    public class BaseInfo
    {
        /// <summary>
        /// 卡券的商户logo，建议像素为300*300。
        /// </summary>
        public string logo_url { get; set; }
        /// <summary>
        ///码型： "CODE_TYPE_TEXT"文 本 ； "CODE_TYPE_BARCODE"一维码 "CODE_TYPE_QRCODE"二维码 "CODE_TYPE_ONLY_QRCODE",
        ///<para>二维码无code显示； "CODE_TYPE_ONLY_BARCODE",一维码无code显示；CODE_TYPE_NONE， 不显示code和条形码类型</para>
        /// </summary>
        public string code_type { get; set; }
        /// <summary>
        /// 商户名字,字数上限为12个汉字。 比如：海底捞
        /// </summary>
        public string brand_name { get; set; }
        /// <summary>
        /// 卡券名，字数上限为9个汉字。(建议涵盖卡券属性、服务及金额)。  比如：双人套餐100元兑换券
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 券颜色。按色彩规范标注填写Color010-Color100。 比如：Color010
        /// </summary>

        public string color { get; set; }
        /// <summary>
        /// 卡券使用提醒，字数上限为16个汉字。 比如：请出示二维码
        /// </summary>
        public string notice { get; set; }
        /// <summary>
        /// 卡券使用说明，字数上限为1024个汉字。比如：不可与其他优惠同享
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 商品信息。 JSON结构 
        /// 如："sku": {
        ///          "quantity": 500000
        ///      },
        /// </summary>
        public Sku sku { get; set; }
        /// <summary>
        /// 使用日期，有效期的信息。
        /// </summary>
        public Date_info date_info { get; set; }

        /// <summary>
        /// 非必填： 是否自定义Code码 。填写true或false，默认为false。 
        /// 通常自有优惠码系统的开发者选择 自定义Code码，并在卡券投放时带入 Code码，详情见 是否自定义Code码 。
        /// </summary>
        public bool use_custom_code { get; set; }
        /// <summary>
        /// 非必填 填入 GET_CUSTOM_CODE_MODE_DEPOSIT 表示该卡券为预存code模式卡券， 须导入超过库存数目的自定义code后方可投放， 填入该字段后，quantity字段须为0,须导入code 后再增加库存
        /// </summary>
        public string get_custom_code_mode { get; set; }
        /// <summary>
        /// 非必填 是否指定用户领取，填写true或false 。默认为false。通常指定特殊用户群体 投放卡券或防止刷券时选择指定用户领取。
        /// </summary>
        public bool bind_openid { get; set; }
        /// <summary>
        /// 非必填 客服电话。
        /// </summary>
        public string service_phone { get; set; }
        /// <summary>
        /// 非必填 门店位置poiid。 调用 POI门店管理接 口 获取门店位置poiid。具备线下门店 的商户为必填。
        /// </summary>
        public int[] location_id_list { get; set; }
        /// <summary>
        /// 非必填 设置本卡券支持全部门店，与location_id_list互斥
        /// </summary>
        public bool? use_all_locations { get; set; }
        /// <summary>
        /// 非必填 卡券顶部居中的按钮，仅在卡券状 态正常(可以核销)时显示
        /// </summary>
        public string center_title { get; set; }
        /// <summary>
        /// 非必填 显示在入口下方的提示语 ，仅在卡券状态正常(可以核销)时显示。
        /// </summary>
        public string center_sub_title { get; set; }
        /// <summary>
        /// 非必填 顶部居中的url ，仅在卡券状态正常(可以核销)时显示。
        /// </summary>
        public string center_url { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的user_name，仅可跳转该 公众号绑定的小程序 。
        /// </summary>
        public string center_app_brand_user_name { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的path
        /// </summary>
        public string center_app_brand_pass { get; set; }
        /// <summary>
        /// 非必填 自定义跳转外链的入口名字。
        /// </summary>
        public string custom_url_name { get; set; }
        /// <summary>
        /// 非必填 自定义跳转的URL。
        /// </summary>
        public string custom_url { get; set; }
        /// <summary>
        /// 非必填 显示在入口右侧的提示语。
        /// </summary>
        public string custom_url_sub_title { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的user_name，仅可跳转该 公众号绑定的小程序 。
        /// </summary>
        public string custom_app_brand_user_name { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的path
        /// </summary>
        public string custom_app_brand_pass { get; set; }
        /// <summary>
        /// 非必填 营销场景的自定义入口名称。
        /// </summary>
        public string promotion_url_name { get; set; }
        /// <summary>
        /// 非必填 入口跳转外链的地址链接。
        /// </summary>
        public string promotion_url { get; set; }
        /// <summary>
        /// 非必填 显示在营销入口右侧的提示语。
        /// </summary>
        public string promotion_url_sub_title { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的user_name，仅可跳转该 公众号绑定的小程序 。
        /// </summary>
        public string promotion_app_brand_user_name { get; set; }
        /// <summary>
        /// 非必填 卡券跳转的小程序的path
        /// </summary>
        public string promotion_app_brand_pass{get;set;}
        /// <summary>
        /// 非必填 每人可领券的数量限制,不填写默认为50。
        /// </summary>
        public int? get_limit { get; set; }
        /// <summary>
        ///非必填 每人可核销的数量限制,不填写默认为50。
        /// </summary>
        public int? use_limit { get; set; }
        /// <summary>
        /// 非必填 卡券领取页面是否可分享。
        /// </summary>
        public bool? can_share { get; set; }
        /// <summary>
        /// 非必填 卡券是否可转赠。
        /// </summary>
        public bool? can_give_friend { get; set; }
    }
    public class Sku
    {
        /// <summary>
        /// 卡券库存的数量，上限为100000000。
        /// </summary>
        public int quantity { get; set; }
    }
    public class Date_info
    {
        /// <summary>
        /// 使用时间的类型，旧文档采用的1和2依然生效。
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 	type为DATE_TYPE_FIX_TIME_RANGE时专用，表示起用时间。从1970年1月1日00:00:00至起用时间的秒数，最终需转换为字符串形态传入。（东八区时间,UTC+8，单位为秒）
        /// </summary>
        public int begin_timestamp { get; set; }
        /// <summary>
        /// 表示结束时间 ， 建议设置为截止日期的23:59:59过期 。 （ 东八区时间,UTC+8，单位为秒 ）
        /// </summary>
        public int end_timestamp { get; set; }
        /// <summary>
        /// type为DATE_TYPE_FIX_TERM时专用，表示自领取后多少天内有效，不支持填写0。
        /// </summary>
        public int fixed_term { get; set; }
        /// <summary>
        /// type为DATE_TYPE_FIX_TERM时专用，表示自领取后多少天开始生效，领取后当天生效填写0。（单位为天）
        /// </summary>
        public int fixed_begin_term { get; set; }

    }
}
