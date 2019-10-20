using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<FlowerDto> Flowers { get; set; }
        public DbSet<OrderDto> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FlowerDto>()
                .HasData(
                    new FlowerDto()
                    {
                        Id = 1,
                        Name = "Daisy",
                        Type = "Branch",
                        LatinName = "Gerbera Daisy",
                        TitleImage = "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/title-imgs/daisy-title.jpg?raw=true",
                        BloomTime = "summer",
                        Humidity = "low",
                        Light = "sunlight",
                        Description = "A plant that lasts many years and is characterised by its big and beautiful flowers that can be in many vivid colours.",
                        Price = 120,
                        Images = new List<string>() {
                            "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/flower-imgs/daisy-1.jpg?raw=true",
                            "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/flower-imgs/daisy-2.jpg?raw=true",
                            "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/flower-imgs/daisy-3.jpg?raw=true",
                            "https://github.com/kristina-s/Frontend-project-resourses/blob/master/images/branch/flower-imgs/daisy-4.jpg?raw=true"
                        }
                    });

        }
    }
}
