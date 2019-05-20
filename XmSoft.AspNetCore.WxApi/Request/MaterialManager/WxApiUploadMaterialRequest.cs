using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.MaterialManager;

namespace XmSoft.AspNetCore.WxApi.Request.MaterialManager
{
    /// <summary>
    /// 新增其他类型永久素材
    /// </summary>
    public class WxApiUploadMaterialRequest: IWxApiRequest<WxApiUploadMaterialResponse>
    {
        /// <summary>
        /// 新增其他类型永久素材 -- 公众平台
        /// <para>通过POST表单来调用接口，表单id为media，包含需要上传的素材内容，有filename、filelength、content-type等信息。</para>
        /// <para>请注意：图片素材将进入公众平台官网素材管理模块中的默认分组</para>
        /// </summary>
        public WxApiUploadMaterialRequest()
        {
           
        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb）
        /// </summary>
        public MsgType Type { get; set; }

        /// <summary>
        /// 文件本地绝对路径
        /// </summary>
        public string MediaPath { get; set; }
        /// <summary>
        /// 在上传视频素材时需要POST另一个表单，id为description，包含素材的描述信息，内容格式为JSON
        /// </summary>
        public Description Description { get; set; }

        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/material/add_material";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                {"type" ,Enum.GetName(typeof(MsgType), Type).ToLower() },
                {"media_path",MediaPath },
                {"description",Description == null ? null : JsonConvert.SerializeObject(Description) }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    /// <summary>
    /// 针对视频
    /// </summary>
    public class Description
    {
        public string title { get; set; }
        public string introduction { get; set; }
    }
}
