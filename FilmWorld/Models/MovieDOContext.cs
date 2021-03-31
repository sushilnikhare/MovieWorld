using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MoviesDO;

namespace FilmWorld.Models
{
    public class MovieDOContext:DbContext
    {
        public DbSet<MovieDO> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Movies.db");
    }

}
