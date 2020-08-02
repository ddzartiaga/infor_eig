using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class ImageAssetEntityTypeConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> config)
        {
            config.ToTable("ImageAssets");
            config.HasKey(c => c.Id);

            config.Property(c => c.Label).IsRequired();
            config.Property(c => c.Content);
            config.Property(c => c.Location);
            config.Property(c => c.FileType);
            
            
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            //config.HasOne(c => c.Group).WithMany(i => i.Images).HasForeignKey(c => c.GroupId);

        }
    }
}
