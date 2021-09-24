using System.Threading.Tasks;
using WebServiceActorApi.Models;

namespace WebServiceActorApi.Services
{
    public interface IActorApiService
    {
        //[Get("/en/API/SearchName/k_tyhzd992/{title}")]
        //Task<HttpResponseMessage> GetActorsAsync(string title);
        Task<ActorResponse> GetActorsAsync();
    }
}
