using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Security;

namespace XmSoft.AspNetCore.WxApi.Request.Security
{
    /// <summary>
    ///校验一张图片是否含有违法违规内容。
    /// </summary>
    public class WxApiImgSecCheckRequest : IWxApiRequest<WxApiImgSecCheckResponse>
    {
        /// <summary>
        /// 校验一张图片是否含有违法违规内容。
        /// <para>图片智能鉴黄：涉及拍照的工具类应用(如美拍，识图类应用)用户拍照上传检测；电商类商品上架图片检测；媒体类用户文章里的图片检测等</para>
        /// <para> 敏感人脸识别：用户头像；媒体类用户文章里的图片检测；社交类用户上传的图片检测等。 频率限制：单个 appId 调用上限为 2000 次/分钟，200,000 次/天*（图片大小限制：1M）</para>
        /// </summary>
        public WxApiImgSecCheckRequest()
        {

        }
        public string AccessToken { get; set; }

        /// <summary>
        /// 媒体文件路径
        /// </summary>
        public string MediaPath { get; set; }


        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/img_sec_check";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                {"media_path",MediaPath }
               
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
