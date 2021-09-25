using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using WebServiceActorApi.Models;


namespace WebServiceActorApi.Services
{
    public class ActorApiService: IActorApiService
    {
        
        IJsonSerializer serializer = new JsonSerializerService();
        IActorApi _actorApi;
        public ActorApiService()
        {
            _actorApi = RestService.For<IActorApi>("https://imdb-api.com");

        }

        public async Task<ActorResponse> GetActorsAsync(string title)
        {
            var response = await _actorApi.GetActorsAsync(title);
            if (response.IsSuccessStatusCode)
            {
                var payload = await response.Content.ReadAsStringAsync();
                var actorResponse = serializer.Deserialize<ActorResponse>(payload);
                return actorResponse;
            }
            return null;
        }

        
    }

}
