using System.Threading.Tasks;
using WebServiceActorApi.Models;

namespace WebServiceActorApi.Services
{
    public interface IActorApiService
    {
        Task<ActorResponse> GetActorsAsync(string title);
    }
}
