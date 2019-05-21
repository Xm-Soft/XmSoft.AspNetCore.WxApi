using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.MaterialManager
{
    /// <summary>
    /// 获取永久素材
    /// </summary>
    public class WxApiGetMaterialResponse : WxApiFileResponse
    {
        /// <summary>
        /// 获取永久素材 - 公众平台
        /// </summary>
        public WxApiGetMaterialResponse()
        {

        }
        /// <summary>
        /// 图文素材
        /// </summary>
        [JsonProperty(PropertyName = "news_item")]
        public List<NewItem> News_item { get; set; }
        /// <summary>
        /// 视频素材标题
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
        /// <summary>
        /// 视频描述
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 视频下载地址
        /// </summary>
        [JsonProperty(PropertyName = "down_url")]
        public string Down_url { get; set; }


    }
    public class NewItem
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 图文消息的封面图片素材id（必须是永久mediaID）
        /// </summary>
        public string thumb_media_id { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 图文消息的摘要，仅有单图文消息才有摘要，多图文此处为空。如果本字段为没有填写，则默认抓取正文前64个字。 非必填
        /// </summary>
        public string digest { get; set; }
        /// <summary>
        /// 是否显示封面，0为false，即不显示，1为true，即显示
        /// </summary>
        public int show_cover_pic { get; set; }
        /// <summary>
        /// 图文消息的具体内容，支持HTML标签，必须少于2万字符，小于1M，
        /// 且此处会去除JS,涉及图片url必须来源 "上传图文消息内的图片获取URL"接口获取。外部图片url将被过滤
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 图文消息的原文地址，即点击“阅读原文”后的URL
        /// </summary>
        public string content_source_url { get; set; }
        /// <summary>
        /// Uint32 是否打开评论，0不打开，1打开 非必填
        /// </summary>
        public int need_open_comment { get; set; }
        /// <summary>
        /// Uint32 是否粉丝才可评论，0所有人可评论，1粉丝才可评论 非必填
        /// </summary>
        public int only_fans_can_comment { get; set; }
    }
}
