using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebServiceActorApi.Models
{
    public class ActorResponse
    {

        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("results")]
        public List<Actor> Actors { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        //public string SearchType { get; set; }
        //public string Expression { get; set; }
        //public ObservableCollection<Actor> Actors { get; set; }
        //public string ErrorMessage { get; set; }
        //public string Title { get; set; }
        //public string Image { get; set; }

    }
}
