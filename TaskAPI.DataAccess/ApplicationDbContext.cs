using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = NIPUNA; Integrated Security=True; Database = MyTodoDb; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new() { Id = 1 , AuthorName = "Martin Wickramasinghe", AddressNo = "23" , Street = "Street1" , City = "Colombo", JobRole = "Developer"},
                new() { Id = 2 , AuthorName = "Kumarathunga Munidasa",AddressNo = "25" , Street = "Street1" , City = "Colombo", JobRole = "Developer"},
                new() { Id = 3 , AuthorName = "Mahagama Sekara", AddressNo = "27" , Street = "Street2" , City = "Colombo", JobRole = "QA"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[] 
            {
                new(){                    
                Id = 1,
                Title = "Get books for school",
                Description = "Description 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1
                },
                new() {
                Id = 2,
                Title = "Get books for school2",
                Description = "Description 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId =2
                },
                new() {
                Id = 3,
                Title = "Get books for school3",
                Description = "Description 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed,
                AuthorId =3
                },
                                new() {
                Id = 4,
                Title = "Get books for school4",
                Description = "Description 4",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId =1
                }
             });
        }
    }
}


//dotnet ef database update --project .\TaskAPI.DataAccess
//dotnet ef migrations add seedData --project .\TaskAPI.DataAccess

