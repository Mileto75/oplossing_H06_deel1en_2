using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Domain.Entities
{
    public class Movie
    {
        //[Key]
        public long Id { get; set; }

        //[Required]
        //[MaxLength(200)]
        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }
    }
}
