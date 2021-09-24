using System.Net.Http;
using System.Threading.Tasks;
using WebServiceActorApi.Models;


namespace WebServiceActorApi.Services
{
    public class ActorApiService: IActorApiService
    {
        static string _apiKey = "k_tyhzd992";
        IJsonSerializer serializer = new JsonSerializerService();
        //IActorApiService _actorApi;
        public async Task<ActorResponse> GetActorsAsync(string title)
        {
            ActorResponse actorResponse = new ActorResponse();
            HttpClient httpClient = new HttpClient();

            string uriString = $"https://imdb-api.com/en/API/SearchName/{_apiKey}/{title}";
            var request = new HttpRequestMessage()
            {

                Method = HttpMethod.Get,
                RequestUri = new System.Uri(uriString),
                Headers = {
                    { "Domain","imdb-api"},
                    { "apiKey", "k_tyhzd992" },

                }
            };
            using (var response = await httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var payload = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    actorResponse = await Task.Run(() => serializer.Deserialize<ActorResponse>(payload)).ConfigureAwait(false);

                }

                return actorResponse;
            }

        }
        //public ActorApiService()
        //{
        //    _actorApi = RestService.For<IActorApiService>("https://imdb-api.com");

        //}


        //public async Task<ActorResponse>GetActorsAsync(string title)
        //{
        //    var response = await _actorApi.GetActorsAsync(title);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var payload = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        //        var actorResponse = serializer.Deserialize<ActorResponse>(payload);
        //        return actorResponse;
        //    }
        //    return null;

        //}
    }

}
