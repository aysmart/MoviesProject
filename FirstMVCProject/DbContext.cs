using FirstMVCProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FirstMVCProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //configure inmemory database for entityframework
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MovieDB");
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
