using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csApiRestful304.src.model;
using Microsoft.EntityFrameworkCore;

namespace csApiRestful304.src.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
        public DbSet<VideoGameDetails> VideoGameDetails => Set<VideoGameDetails>();
    }
}