using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Web.Domain.Entities
{
    public class User
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string Username { get; set; }

        //[MaxLength(100)]
        public string FirstName { get; set; }

        //[MaxLength(100)]
        public string LastName { get; set; }

    }
}
