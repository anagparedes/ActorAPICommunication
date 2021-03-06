using System.Text.Json;

namespace WebServiceActorApi.Services
{
    public class JsonSerializerService : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;
        public JsonSerializerService()
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        
        }

        public T Deserialize<T>(string payload) => JsonSerializer.Deserialize<T>(payload, _options);

        public string Serialize(object payload) => JsonSerializer.Serialize(payload, _options);
        
    }
}
