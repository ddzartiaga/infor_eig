using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository
{
    public class DatabaseContext : DbContext
    {
        DbSet<EIGroup> EIGs { get; set; }
        DbSet<Event> Events { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EIGEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new EIGEntityTypeConfiguration());
        }
    }
}
