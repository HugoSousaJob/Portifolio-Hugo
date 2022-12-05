
using Portifolio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Models.ModelsService;

namespace Portifolio.Data.Dtos
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco).HasForeignKey<Cinema>(cinema => cinema.Id);
        }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Empresa> Empresa{ get; set; }

    }
}
