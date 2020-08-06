using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ADAGroup.EIG.Domain;
using Microsoft.VisualBasic;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<InterestGroup>
    {
        public void Configure(EntityTypeBuilder<InterestGroup> config)
        {
            config.ToTable("InterestGroups");
            config.HasKey(c => c.Id);
            config.Property(c => c.Id).ValueGeneratedOnAdd();

            config.Property(c => c.Name).IsRequired();
            config.Property(c => c.GoalAndPurpose).IsRequired();
            config.Property(c => c.Mission).IsRequired();
            

            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();

            config.HasMany(c => c.Activities).WithOne(a => a.Group).HasForeignKey(a => a.GroupId);
            config.HasMany(c => c.Images);


            //config.HasData(new InterestGroup() {
            //    Id = Guid.NewGuid(),
            //    Name = "Infor Musiko",
            //    GoalAndPurpose = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus.",
            //    Mission = "Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue.",
            //    DateCreated = DateTime.UtcNow,
            //});

            //config.HasData(new InterestGroup()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Infor Football Club",
            //    GoalAndPurpose = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus.",
            //    Mission = "Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue.",
            //    DateCreated = DateTime.UtcNow,
            //});

            //config.HasData(new InterestGroup()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Infor Multisport",
            //    GoalAndPurpose = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus.",
            //    Mission = "Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue.",
            //    DateCreated = DateTime.UtcNow,
            //});
        }
    }
}
