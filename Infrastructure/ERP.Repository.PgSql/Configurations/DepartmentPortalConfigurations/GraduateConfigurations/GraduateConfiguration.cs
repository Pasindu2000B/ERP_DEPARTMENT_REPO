using Bogus;
using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.GraduateConfigurations
{
    public class GraduateConfiguration : IEntityTypeConfiguration<Graduate>
    {
        public void Configure(EntityTypeBuilder<Graduate> builder)
        {
            builder.HasData(Enumerable.Range(1, 3).Select(
                index => new Faker<Graduate>()
                .RuleFor(s => s.GraduateID, index + 1000)
                .RuleFor(s => s.GraduateName, f => f.Name.FirstName())
                .RuleFor(s => s.GraduateDescription, f => f.Name.JobDescriptor())
                .RuleFor(s => s.GraduateContactNo, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.GraduateCompany, f => f.Address.FullAddress()).Generate()
                )
            );
        }
    }
}
