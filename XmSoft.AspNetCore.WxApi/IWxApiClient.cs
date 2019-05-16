using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    public interface IWxApiClient
    {
        void Dispose();
        Task<T> ExecuteAsync<T>(IWxApiRequest<T> request, string UploadFilePath = null) where T : WxApiResponse;
    }
}