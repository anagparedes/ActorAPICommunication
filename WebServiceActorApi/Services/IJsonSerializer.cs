using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

namespace WebServiceActorApi.Services
{
    public interface IJsonSerializer
    {
        string Serialize(object payload);
        T Deserialize<T>(string payload);
    }
}
