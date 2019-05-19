using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.CustomerMessage;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.CustomerMessage
{
    /// <summary>
    /// 发送客服消息给用户。详细规则见 发送客服消息
    /// </summary>
    public class WxApiSendMessageRequest : IWxApiRequest<WxApiSendMessageResponse>
    {
        /// <summary>
        /// 发送客服消息给用户。详细规则见 发送客服消息
        /// </summary>
        public WxApiSendMessageRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        public string Touser { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public MsgType MsgType { get; set; }
        /// <summary>
        /// 文本消息内容，msgtype="text" 时必填
        /// </summary>

        public TextObject Text { get; set; }
        /// <summary>
        /// 图片消息，msgtype="link" 时必填
        /// </summary>

        public ImageObject Image { get; set; }
        /// <summary>
        /// 图片消息，msgtype="link" 时必填
        /// </summary>
        public LinkObject Link { get; set; }
        /// <summary>
        /// 小程序卡片，msgtype="miniprogrampage" 时必填
        /// </summary>
        public Miniprogrampage Minprogrampage { get; set; }
        /// <summary>
        /// 发送视频消息
        /// </summary>
        public VideoObject Video { get; set; }
        /// <summary>
        /// 发送语音消息
        /// </summary>
        public VoiceObject Voice { get; set; }
        /// <summary>
        /// 发送音乐消息
        /// </summary>
        public MusicObject Music { get; set; }
        /// <summary>
        /// 发送图文消息（点击跳转到外链） 图文消息条数限制在1条以内，注意，如果图文数超过1，则将会返回错误码45008。
        /// </summary>
        public NewsObject News { get; set; }
        /// <summary>
        /// 图文消息 （点击跳转到图文消息页面） 图文消息条数限制在1条以内，注意，如果图文数超过1，则将会返回错误码45008。
        /// </summary>
        public MpNews MpNews { get; set;}
        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/message/custom/send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "touser", Touser },
                { "msgtype",Enum.GetName(typeof(MsgType), MsgType).ToLower() },
                {"text",Text == null?null:JsonConvert.SerializeObject(Text) },
                {"image",Image == null? null: JsonConvert.SerializeObject(Image) },
                {"link",Link == null ? null : JsonConvert.SerializeObject(Link) },
                {"minprogrampage",Minprogrampage== null ? null: JsonConvert.SerializeObject(Minprogrampage) },
                {"music",Music == null ? null: JsonConvert.SerializeObject(Music) },
                {"news",News == null ? null : JsonConvert.SerializeObject(News) },
                {"voice",Voice == null ? null : JsonConvert.SerializeObject(Voice) },
                {"video",Video == null ? null : JsonConvert.SerializeObject(Video) },
                {"mpnews",MpNews == null ? null : JsonConvert.SerializeObject(MpNews) }

            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    public class ImageObject
    {
        /// <summary>
        /// 发送的图片的媒体ID，通过 新增素材接口 上传图片文件获得。
        /// </summary>
        public string media_id { get; set; }
    }
    public class LinkObject
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 图文链接消息
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 图文链接消息被点击后跳转的链接
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 图文链接消息的图片链接，支持 JPG、PNG 格式，较好的效果为大图 640 X 320，小图 80 X 80
        /// </summary>
        public string thumb_url { get; set; }
    }
    public class Miniprogrampage
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 小程序的页面路径，跟app.json对齐，支持参数，比如pages/index/index?foo=bar
        /// </summary>
        public string pagepath { get; set; }
        /// <summary>
        /// 小程序消息卡片的封面， image 类型的 media_id，通过 新增素材接口 上传图片文件获得，建议大小为 520*416
        /// </summary>
        public string thumb_media_id { get; set; }
    }
    public class VoiceObject
    {
        /// <summary>
        /// 发送的语音的媒体ID，通过 新增素材接口 上传图片文件获得。
        /// </summary>
        public string media_id { get; set; }
    }
    /// <summary>
    /// 视频
    /// </summary>
    public class VideoObject
    {
        public string media_id { get; set; }
        public string thumb_media_id { get; set; }
        public string title { get; set; }

        public string description { get; set; }
    }
    /// <summary>
    /// 音乐
    /// </summary>
    public class MusicObject
    {
        public string title { get; set; }

        public string description { get; set; }
        public string musicurl { get; set; }
        public string hqmusicurl { get; set; }
        public string thumb_media_id { get; set; }
    }
    /// <summary>
    /// 新闻消息：发送图文消息（点击跳转到外链） 图文消息条数限制在1条以内，注意，如果图文数超过1，则将会返回错误码45008。
    /// </summary>
    public class NewsObject
    {
        public Articles articles { get; set; }
    }

    public class Articles
    {
        public string title { get; set; }

        public string description { get; set; }
        public string url { get; set; }
        public string picurl { get; set; }
    }
    /// <summary>
    /// 发送图文消息（点击跳转到图文消息页面） 图文消息条数限制在1条以内，注意，如果图文数超过1，则将会返回错误码45008。
    /// </summary>
    public class MpNews
    {
        public string media_id { get; set; }
    }
    /// <summary>
    /// 文本
    /// </summary>
    public class TextObject
    {
        public string content { get; set; }
    }
    
}
