namespace XmSoft.AspNetCore.WxApi.Parser
{
    public interface IWeChatPayXmlParser<T> where T : WxApiXmlObject
    {
        T Parse(string body);
        T Parse(string body, string data);
    }
}