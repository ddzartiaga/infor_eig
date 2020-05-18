using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class ImageAssetEntityTypeConfiguration : IEntityTypeConfiguration<ImageAsset>
    {
        public void Configure(EntityTypeBuilder<ImageAsset> config)
        {
            config.ToTable("ImageAssets");
            config.HasKey(c => c.Id);
            config.HasOne(c => c.Group).WithMany(i => i.Images).HasForeignKey(c => c.GroupId);
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

        }
    }
}
