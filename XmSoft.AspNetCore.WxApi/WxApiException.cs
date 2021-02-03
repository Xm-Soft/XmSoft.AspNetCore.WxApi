using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    public class WxApiException : Exception
    {
        public WxApiException(string messages) : base(messages)
        {
        }
    }

}
