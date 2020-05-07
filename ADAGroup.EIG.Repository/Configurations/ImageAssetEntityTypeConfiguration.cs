using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class ImageAssetEntityTypeConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> config)
        {
            config.ToTable("ImageAssets");
            config.HasKey(c => c.Id);
            config.HasOne(c => c.Group).WithMany(i => i.Activities).HasForeignKey(c => c.GroupId);
            config.Property(c => c.Title).IsRequired();
            config.Property(c => c.Description);
            config.Property(c => c.Location);
            config.Property(c => c.Hosts);
            config.Property(c => c.StartDateTime);
            config.Property(c => c.EndDateTime);
            config.Property(c => c.Location);
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

        }
    }
}
