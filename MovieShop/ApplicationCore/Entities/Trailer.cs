using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
   public class Trailer
    {
        public int Id { get; set; }
        
        public string TrailerUrl { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }

        // Navigation Property, this means trailer belongs to one movie
        public Movie Movie { get; set; }
    }
}
