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
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        
    }
}