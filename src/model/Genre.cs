using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csApiRestful304.src.model
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [JsonIgnore]
        public List<VideoGame>? VideoGames { get; set; }
    }
}