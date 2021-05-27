using ExaminationSystem.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();

            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Name).HasMaxLength(100);

            builder.ToTable("OperationClaims");

            builder.HasData(
                new OperationClaim
                {
                    Id = 1,
                    Name = "Yönetici"
                },
                new OperationClaim
                {
                    Id = 2,
                    Name = "Öğrenci"
                }
                );
        }
    }
}

