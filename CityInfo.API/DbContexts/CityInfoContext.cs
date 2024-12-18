﻿using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
      

        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
  
        public CityInfoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with the big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral that never really finished."
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one with that big tower."
                });
            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("intersest 1")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "blablabla"
                },
                new PointOfInterest("interest 2")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "lNDalwnf"
                },
                new PointOfInterest("interest 3")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "osngrjns"
                });
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
