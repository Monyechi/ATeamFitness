using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ATeamFitness.Models;

namespace ATeamFitness.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"

            },

            new IdentityRole
            {
                Name = "PersonTrainer",
                NormalizedName = "PERSONAL TRAINER"
            }
            );
        }
<<<<<<< HEAD
=======
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PersonalTrainer> PersonalTrainers { get; set; }
>>>>>>> 994532af78aa1ced2cea9e00aae30f3a0e518982
    }
}
