using Bogus;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.LabConfigurations
{
    internal class LabSpaceConfiguration : IEntityTypeConfiguration<LabSpace>
    {
        public void Configure(EntityTypeBuilder<LabSpace> builder)
        {
            string[] Labs = { "Electronic Lab", "High Voltage Lab", "Signal and Systems Labs","Computer Lab","Information Engineering Lab","Power System Lab"};
            Random rnd = new Random();

            builder.HasData(

               Enumerable.Range(1, 3).Select(
                   index => new Faker<LabSpace>()
                         .RuleFor(s => s.LabSpaceId, index + 20)
                         .RuleFor(s => s.LabSpaceName,f=>f.Name.FirstName())
                        
                         .Generate()

               )
            );
        }
    }
}
