using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataModels
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<FlowerDto> Flowers { get; set; }
        public DbSet<OrderDto> Orders { get; set; }
        public DbSet<UserDto> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDto>()
                .HasOne(x => x.User)
                .WithMany(x => x.OrderList)
                .HasForeignKey(x => x.UserId);

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
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(
                Encoding.ASCII.GetBytes("1234"));
            var hashedPassword = Encoding.ASCII.GetString(md5data);

            builder.Entity<UserDto>()
                .HasData(
                new UserDto()
                {
                    Id = 1,
                    FirstName = "Kristina",
                    LastName = "Spasevska",
                    Username = "kiki",
                    Password = hashedPassword
                });

            
        }
    }
}
