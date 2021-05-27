using ExaminationSystem.Core.Entities.Concrete;
using ExaminationSystem.Core.Utilities.Security.Hashing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(30);

            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30);

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(100);

            builder.Property(u => u.PasswordSalt).IsRequired();
            builder.Property(u => u.PasswordSalt).HasColumnType("VARBINARY(500)");

            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");

            builder.ToTable("Users");

            byte[] userMeralPasswordSalt, userMeralPasswordHash, userFikretPasswordSalt, userFikretPasswordHash;
            HashingHelper.CreatePasswordHash("meral123", out userMeralPasswordHash, out userMeralPasswordSalt);
            HashingHelper.CreatePasswordHash("evogens123", out userFikretPasswordHash, out userFikretPasswordSalt);


            var userFikret = new User
            {
                Id = 1,
                FirstName = "Fikret",
                LastName = "Yeşilyayla",
                Email = "fikret@gmail.com",
                PasswordHash = userFikretPasswordHash,
                PasswordSalt = userFikretPasswordSalt

            };
            var userMeral = new User
            {
                Id = 2,
                FirstName = "Meral",
                LastName = "Taşdemir",
                Email = "meral@gmail.com",
                PasswordHash = userMeralPasswordHash,
                PasswordSalt = userMeralPasswordSalt

            };
           
            builder.HasData(userMeral,userFikret);

        }
    }
}
