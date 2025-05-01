using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csApiRestful304.src.model
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Plataform { get; set; }
        public int? DeveloperId { get; set; }
        public Developer? Developer { get; set; }
        public int? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public VideoGameDetails? VideoGameDetails { get; set; } 
        public List<Genre>? Genres { get; set; }
    }
}