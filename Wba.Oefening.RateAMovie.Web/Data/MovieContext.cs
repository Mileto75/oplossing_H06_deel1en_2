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

            //Configure the User Entity
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);//primary key in principte overbodig
            //want we volgen de conventie Id naam

            modelBuilder.Entity<User>()
                .Property(u => u.Id)//selecteer Id prop
                .UseSqlServerIdentityColumn();//autoincrement

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .HasMaxLength(100);

            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .HasMaxLength(100);

            //Configure the Movie Entity
            modelBuilder.Entity<Movie>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Movie>()
                .Property(u => u.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Movie>()
                .Property(u => u.Title)
                .IsRequired()
                .HasMaxLength(200);

            //Configure the Actor Entity
            modelBuilder.Entity<Actor>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Actor>()
                .Property(u => u.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Actor>()
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Actor>()
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);

            
            


            
        }

    }
}
