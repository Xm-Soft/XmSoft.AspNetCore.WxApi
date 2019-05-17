using System.IO;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    public interface IWxApiNotifyClient
    {
        void Dispose();
        Task<T> ExecuteAsync<T>(Stream stream) where T : WxApiNotify;
    }
}