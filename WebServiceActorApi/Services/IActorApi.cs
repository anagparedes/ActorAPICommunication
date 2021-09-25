using Refit;
using System.Net.Http;
using System.Threading.Tasks;


namespace WebServiceActorApi.Services
{
    public interface IActorApi
    {
     
        [Get("/en/API/SearchName/k_tyhzd992/{title}")]
        Task<HttpResponseMessage> GetActorsAsync(string title);
    }
}
