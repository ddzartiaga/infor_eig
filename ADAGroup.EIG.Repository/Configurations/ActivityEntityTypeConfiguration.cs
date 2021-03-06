﻿using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class ActivityEntityTypeConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> config)
        {
            config.ToTable("Activities");
            config.HasKey(c => c.Id);
           
            config.Property(c => c.Title).IsRequired();
            config.Property(c => c.Details).IsRequired();
            config.Property(c => c.Location);
            config.Property(c => c.StartDateTime).IsRequired();
            config.Property(c => c.EndDateTime);
            
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            config.HasOne(c => c.Group).WithMany(i => i.Activities).HasForeignKey(c => c.GroupId);
        }
    }
}
