using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Parser
{
    public class WxApiJsonParser<T>: IWxApiJsonParser<T> where T : WxApiObject
    {
        public T Parse(string body)
        {
            T result = null;
            var parameters = new WxApiDictionary();

            try
            {
                result = JsonConvert.DeserializeObject<T>(body);

            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            if (result != null)
            {
                result.Body = body;

                result.Parameters = parameters;
            }

            return result;
        }
    }
}
