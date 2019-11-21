using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using K9TB;

namespace K9TitleBuilder.Data
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
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Sire self-referential relationship
            builder.Entity<Dog>().
                HasOne(d => d.Sire).
                WithMany().
                HasForeignKey(s => s.SireId);

            // Dam self-referential relationship
            builder.Entity<Dog>().
                HasOne(d => d.Dam).
                WithMany().
                HasForeignKey(f => f.DamId);
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<ShowEvent> ShowEvent { get; set; }
        public DbSet<Breeder> Breeder { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<MediaItem> MediaItem { get; set; }
        public DbSet<Ribbon> Ribbon { get; set; }
        public DbSet<Run> Run { get; set; }
        public DbSet<Leg> Leg { get; set; }
        public DbSet<Title> Title { get; set; }
    }
}
