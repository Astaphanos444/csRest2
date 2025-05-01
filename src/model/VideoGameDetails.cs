using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csApiRestful304.src.model
{
    public class VideoGameDetails
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int VideoGameId { get; set;} 
    }
}