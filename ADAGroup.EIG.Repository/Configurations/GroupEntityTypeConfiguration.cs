using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ADAGroup.EIG.Domain;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<InterestGroup>
    {
        public void Configure(EntityTypeBuilder<InterestGroup> config)
        {
            config.ToTable("EIGs");
            config.HasKey(c => c.Id);
            config.Property(c => c.Id).ValueGeneratedOnAdd();
            config.HasMany(c => c.Activities).WithOne(a => a.Group).HasForeignKey(a => a.GroupId);
            config.HasMany(c => c.Officers).WithOne(a => a.Group).HasForeignKey(a => a.GroupId);
            config.HasMany(c => c.Images).WithOne(a => a.Group).HasForeignKey(a => a.GroupId);
            config.Property(c => c.Name).IsRequired();
            config.Property(c => c.Vision);
            config.Property(c => c.Mission);
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            config.HasData(new InterestGroup() { Id = Guid.NewGuid(), Name = "Infor Musiko", Vision = "Sample", Mission = "To make our world a better place", 
                DateCreated = DateTime.Now, DateModified = DateTime.Now });
        }
    }
}
