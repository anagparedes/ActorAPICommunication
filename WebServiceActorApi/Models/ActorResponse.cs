
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WebServiceActorApi.Models
{
    public class ActorResponse
    {

        [JsonPropertyName("searchType")]
        public string SearchType { get; set; }

        [JsonPropertyName("expression")]
        public string Expression { get; set; }

        [JsonPropertyName("results")]
        public List<Actor> Actors { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        //public string SearchType { get; set; }
        //public string Expression { get; set; }
        //public ObservableCollection<Actor> Actors { get; set; }
        //public string ErrorMessage { get; set; }
        //public string Title { get; set; }
        //public string Image { get; set; }

    }
}
