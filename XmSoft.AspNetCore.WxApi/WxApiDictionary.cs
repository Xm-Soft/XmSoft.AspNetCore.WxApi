using System;
using System.Collections.Generic;
using System.Text;

namespace XmSoft.AspNetCore.WxApi
{
    public class WxApiDictionary: SortedDictionary<string, object>
    {
        public WxApiDictionary() { }

        public WxApiDictionary(IDictionary<string, object> dictionary)
            : base(dictionary)
        { }

        //public void Add(string key, object value)
        //{
        //    string strValue;

        //    if (value == null)
        //    {
        //        strValue = null;
        //    }
        //    else if (value is string)
        //    {
        //        strValue = (string)value;
        //    }
        //    else if (value is int?)
        //    {
        //        strValue = (value as int?).Value.ToString();
        //    }
        //    else if (value is long?)
        //    {
        //        strValue = (value as long?).Value.ToString();
        //    }
        //    else if (value is double?)
        //    {
        //        strValue = (value as double?).Value.ToString();
        //    }
        //    else if (value is bool?)
        //    {
        //        strValue = (value as bool?).Value.ToString().ToLower();
        //    }
        //    else
        //    {
        //        strValue = value.ToString();
        //    }

        //    Add(key, strValue);
        //}

        public new void Add(string key,object value)
        {
            if(value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                base.Add(key, value);

            }
        }

        public  void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }
        public object GetValue(string key)
        {
            return TryGetValue(key, out var o) ? o : null;
        }
        //public string GetValue(string key)
        //{
        //    return TryGetValue(key, out var o) ? o : null;
        //}

        public object SetValue(string key, string value)
        {
            return base[key] = value;
        }
    }
}
