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
    public class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(uo => new { uo.UserId, uo.OperationClaimId });

            builder.HasOne<User>(uo => uo.User).WithMany(u => u.UserOperationClaims).HasForeignKey(uo => uo.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<OperationClaim>(uo => uo.OperationClaim).WithMany(oc => oc.UserOperationClaims)
                .HasForeignKey(uo => uo.OperationClaimId);

            builder.ToTable("UserOperationClaims");

            builder.HasData(
                new UserOperationClaim
                {
                    Id =1,
                    UserId = 1,
                    OperationClaimId = 1
                },

                new UserOperationClaim
                {
                    Id = 2,
                    UserId = 2,
                    OperationClaimId = 2
                }
                );

        }
    }
}
