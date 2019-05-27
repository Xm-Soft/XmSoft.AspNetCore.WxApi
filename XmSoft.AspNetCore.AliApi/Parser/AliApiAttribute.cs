using System;
using System.Reflection;

namespace XmSoft.AspNetCore.AliApi.Parser
{
    public class AliApiAttribute
    {
        public string ItemName { get; set; }
        public Type ItemType { get; set; }
        public string ListName { get; set; }
        public Type ListType { get; set; }
        public MethodInfo Method { get; set; }
    }
}
