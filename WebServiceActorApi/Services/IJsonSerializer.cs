

namespace WebServiceActorApi.Services
{
    public interface IJsonSerializer
    {
        string Serialize(object payload);
        T Deserialize<T>(string payload);
    }
}
