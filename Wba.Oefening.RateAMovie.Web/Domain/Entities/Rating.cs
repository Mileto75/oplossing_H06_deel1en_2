using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Web.Domain.Entities
{
    public class Rating
    {
        public long Id { get; set; }

        public byte Score { get; set; }

        public string Review { get; set; }
    }
}
