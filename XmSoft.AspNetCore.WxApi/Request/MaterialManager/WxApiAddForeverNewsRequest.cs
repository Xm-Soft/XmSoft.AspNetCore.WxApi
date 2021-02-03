using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 新增永久图文素材
    /// </summary>
    public class WxApiAddForeverNewsRequest : IWxApiRequest<WxApiAddForeverNewsResponse>
    {
        /// <summary>
        ///新增永久图文素材 - 公众平台
        /// </summary>
        public WxApiAddForeverNewsRequest()
        {

        }
        public string AccessToken { get; set; }
        /// <summary>
        /// 图文素材
        /// </summary>
        public List<Articles> Articles { get; set; }
       


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/add_news";
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
                { "articles", Articles }
            };
            return parameters;
        }

        #endregion
    }
    public class Articles
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
