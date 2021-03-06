﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// WxApi 基础对象。
    /// </summary>
    public abstract class WxApiObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [JsonIgnore]
        public WxApiDictionary Parameters { get; internal set; }
    }
}
