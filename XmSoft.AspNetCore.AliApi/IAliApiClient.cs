using System.Threading.Tasks;

namespace XmSoft.AspNetCore.AliApi
{
    public interface IAliApiClient
    {
        void Dispose();
        Task<T> Execute<T>(IAliApiRequest<T> request) where T : AliApiResponse;
        Task<T> Execute<T>(IAliApiRequest<T> request, string accessToken) where T : AliApiResponse;
        Task<T> Execute<T>(IAliApiRequest<T> request, string accessToken, string appAuthToken) where T : AliApiResponse;
        Task<T> pageExecute<T>(IAliApiRequest<T> request) where T : AliApiResponse;
        Task<T> pageExecute<T>(IAliApiRequest<T> request, string accessToken, string reqMethod) where T : AliApiResponse;
        Task<T> SdkExecute<T>(IAliApiRequest<T> request) where T : AliApiResponse;
    }
}