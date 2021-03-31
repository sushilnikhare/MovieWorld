using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDO
{
    public class MovieDO
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }

}
