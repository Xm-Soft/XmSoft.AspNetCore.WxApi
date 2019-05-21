using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Intelligent
{
    public class WxApiTranslateContentResponse : WxApiResponse
    {
        public string from_content { get; set; }
        public string to_content { get; set; }

    }
}
