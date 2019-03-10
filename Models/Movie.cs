using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieDb.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("genres")]
        public IList<Genre> Genres { get; set; }

        [JsonProperty("director")]
        public Director Director { get; set; }
    }
}
