using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WebServiceActorApi.Models
{
    public class Actor
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resultType")]
        public string ResultType { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
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
