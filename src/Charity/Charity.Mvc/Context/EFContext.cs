using Charity.Mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Context
{
    public class EFContext : DbContext
    {
        public EFContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS01;database=charity-donation;trusted_connection=true;");

        }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<DonationModel> Donations { get; set; }
        public DbSet<InstitutionModel> Institutions { get; set; }

        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>();
            modelBuilder.Entity<DonationModel>();
            modelBuilder.Entity<InstitutionModel>();
        }
    }
}
