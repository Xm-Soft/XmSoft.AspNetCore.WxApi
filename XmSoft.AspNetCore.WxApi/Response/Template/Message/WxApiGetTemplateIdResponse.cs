using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template.Message
{
    public class WxApiGetTemplateIdResponse : WxApiResponse
    {
        [JsonProperty(PropertyName = "template_id")]
       public string Template_id { get; set; }
    }
}
