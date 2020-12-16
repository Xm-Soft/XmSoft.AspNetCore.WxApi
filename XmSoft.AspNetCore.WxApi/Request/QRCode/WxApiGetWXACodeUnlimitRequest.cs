using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response;
using XmSoft.AspNetCore.WxApi.Response.QRCode;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    ///获取小程序码，适用于需要的码数量极多的业务场景。
    ///通过该接口生成的小程序码，永久有效，数量暂无限制。 更多用法详见 获取二维码。
    /// </summary>
    public class WxApiGetWXACodeUnlimitRequest : IWxApiRequest<WxApiFileResponse>
    {
        /// <summary>
        /// 获取小程序码，适用于需要的码数量极多的业务场景。
        /// <para>通过该接口生成的小程序码，永久有效，数量暂无限制。 更多用法详见 获取二维码。</para>
        /// </summary>
        public WxApiGetWXACodeUnlimitRequest()
        {
            Width = 430;
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 最大32个可见字符，只支持数字，大小写英文以及部分特殊字符：!#$&'()*+,/:;=?@-._~，
        /// 其它字符请自行编码为合法字符（因不支持%，中文无法使用 urlencode 处理，请使用其他编码方式）
        /// </summary>
        public string Scene { get; set; }
        /// <summary>
        /// 必须是已经发布的小程序存在的页面（否则报错），例如 pages/index/index, 
        /// 根路径前不要填加 /,不能携带参数（参数请放在scene字段里），如果不填写这个字段，默认跳主页面
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 二维码的宽度，单位 px。最小 280px，最大 1280px
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 自动配置线条颜色，如果颜色依然是黑色，则说明不建议配置主色调
        /// </summary>
        public bool Auto_color { get; set; }
        /// <summary>
        /// auto_color 为 false 时生效，使用 rgb 设置颜色 例如 {"r":"xxx","g":"xxx","b":"xxx"} 十进制表示
        /// </summary>
        public Line_Color Line_color { get; set; }
        /// <summary>
        /// 是否需要透明底色，为 true 时，生成透明底色的小程序码
        /// </summary>
        public bool Is_hyaline { get; set; }

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/getwxacodeunlimit";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "scene", Scene },
                {"page",Page },
                { "width", Width },
                { "auto_color", Auto_color },
                { "line_color", Line_color == null ? null:JsonConvert.SerializeObject(Line_color)},
                { "is_hyaline", Is_hyaline }
               
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
   
}
