using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response;
using XmSoft.AspNetCore.WxApi.Response.QRCode;

namespace XmSoft.AspNetCore.WxApi.Request.QRCode
{
    /// <summary>
    /// 获取小程序码，适用于需要的码数量较少的业务场景。通过该接口生成的小程序码，永久有效，有数量限制，详见获取二维码。
    /// </summary>
    public class WxApiGetWXACodeRequest : IWxApiRequest<WxApiFileResponse>
    {
        /// <summary>
        /// 获取小程序码，适用于需要的码数量较少的业务场景。
        /// <para>通过该接口生成的小程序码，永久有效，有数量限制，详见获取二维码。</para>
        /// </summary>
        public WxApiGetWXACodeRequest()
        {
            Width = 430;
        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 扫码进入的小程序页面路径，最大长度 128 字节，不能为空；对于小游戏，
        /// 可以只传入 query 部分，来实现传参效果，如：传入 "?foo=bar"，
        /// 即可在 wx.getLaunchOptionsSync 接口中的 query 参数获取到 {foo:"bar"}。
        /// </summary>
        public string Path { get; set; }
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
            return "https://api.weixin.qq.com/wxa/getwxacode";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "path", Path },
                { "width", Width },
                { "auto_color", Auto_color },
                { "line_color", Line_color == null? null: JsonConvert.SerializeObject(Line_color) },
                { "is_hyaline", Is_hyaline }
            };
            return parameters;
        }

        #endregion
    }
    public class Line_Color
    {
        [JsonProperty(PropertyName ="r")]
        public string R { get; set; }
        [JsonProperty(PropertyName = "g")]
        public string G { get; set; }
        [JsonProperty(PropertyName = "b")]
        public string B { get; set; }
    }
}
