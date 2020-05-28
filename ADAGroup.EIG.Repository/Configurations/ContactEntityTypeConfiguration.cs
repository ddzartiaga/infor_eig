using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> config)
        {
            config.ToTable("GroupContacts");
            config.HasKey(c => c.Id);
            
            config.Property(c => c.Name).IsRequired();
            config.Property(c => c.Designation);
            config.Property(c => c.ContactNumber);
            config.Property(c => c.Email);

            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            config.HasOne(c => c.Group).WithMany(i => i.Contacts).HasForeignKey(c => c.GroupId);

        }
    }
}
