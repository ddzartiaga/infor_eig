using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class FAQEntityTypeConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> config)
        {
            config.ToTable("FAQs");
            config.HasKey(c => c.Id);

            config.Property(c => c.RefId).IsRequired();
            config.Property(c => c.Question).IsRequired();
            config.Property(c => c.Answer).IsRequired();
            config.Property(c => c.EntityType).IsRequired();
            
            
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            //config.HasOne(c => c.Group).WithMany(i => i.Images).HasForeignKey(c => c.GroupId);

        }
    }
}
