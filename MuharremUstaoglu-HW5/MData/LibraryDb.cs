using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuharremUstaoglu_HW5.MData
{
    public class LibraryDb : DbContext
    {
        string connectionString = @"Server=.;Database=CetLibrary;Trusted_Connection=True;";
        public DbSet<CetUser> CetUsers { get; set; }
        public LibraryDb() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CetUser>().HasData(
                new CetUser
                {
                    Id = 1,
                    Name = "Muharrem",
                    Surname = "Ustaoğlu",
                    UserName = "Admin",
                    Password = new Service.CetUserService().hashPassword("admin"),
                    CreatedDate = DateTime.Now,
                    Role="Admin"
                          
                }
            ) ;
        }
    }
}
