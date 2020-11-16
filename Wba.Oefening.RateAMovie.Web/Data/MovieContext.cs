using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.RateAMovie.Domain.Entities;

namespace Wba.Oefening.RateAMovie.Web.Data
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Actor> Actors { get; set; }

        //public DbSet<Director> Directors { get; set; }

        //public DbSet<Company> Companies { get; set; }

        //public DbSet<Rating> Ratings { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            


            
        }

    }
}
