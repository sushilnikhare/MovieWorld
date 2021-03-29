using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace CinemaWorld.Models
{
    public class MovieDOContext:DbContext
    {
        public DbSet<MovieDO> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Movies.db");
    }
    public class MovieDO
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public double Price {get; set;}
    }
}
