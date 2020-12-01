using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Subscribe
{
    /// <summary>
    /// 组合模板并添加至帐号下的个人模板库 返回
    /// <para>200014	模版 tid 参数错误</para>	
    /// <para>200020	关键词列表 kidList 参数错误	</para>
    /// <para>200021	场景描述 sceneDesc 参数错误	</para>
    /// <para>200011	此账号已被封禁，无法操作	</para>
    /// <para>200013	此模版已被封禁，无法选用	</para>
    /// <para>200012	个人模版数已达上限，上限25个</para>
    /// </summary>
    public class WxApiAddTemplateResponse : WxApiResponse
    {

        /// <summary>
        /// 添加至帐号下的模板id，发送小程序订阅消息时所需
        /// </summary>
        [JsonProperty(PropertyName = "priTmplId")]
        public string PriTmplId { get; set; }
    }
}
