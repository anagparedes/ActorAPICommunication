using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebServiceActorApi.Models
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("resultType")]
        public string ResultType { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        //public Actor(string image, string title)
        //{

        //    Image = image;
        //    Title = title;

        //}
        //public List<Actor> Actors = new List<Actor>();
        //public string Id { get; set; }
        //public string ResultType { get; set; }
        //public string Image { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }

    }
   
}
