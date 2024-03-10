using Bogus;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.TrainingConfigurations
{
    internal class TrainingConfigurations : IEntityTypeConfiguration<JobPost>
    {
        public void Configure(EntityTypeBuilder<JobPost> builder)
        {
            string[] job_roles = { "data engineer", "software engineer", "quality assurance Enginner","computer networks engineer","cyber security engineer" };
            string[] categories = { "computer Engineering" };
           
            builder.HasData(

                Enumerable.Range(1, 3).Select(
                    index => new Faker<JobPost>()
                    .RuleFor(s=>s.Id,index+100)
                    .RuleFor(s=>s.CompanyName,f=>f.Company.CompanyName())
                    .RuleFor(s=>s.CompanyEmail, (f,u)=>f.Internet.Email(u.CompanyName))
                    .RuleFor(s=>s.JobDescriptionLink , f=>f.Internet.Url())
                    .RuleFor(s=>s.Category,f=>f.PickRandom(categories))
                    .RuleFor(s=>s.InternPosition, f=>f.PickRandom(job_roles)).Generate()
                    






                    )

               );


        }
    }
}

/* builder.HasData(

Enumerable.Range(1, 3).Select(
    index => new Faker<LabEquipment>()
          .RuleFor(s => s.LabEquipmentID, index + 3000)
          .RuleFor(s => s.LabEquipmentName, f => f.Name.FirstName())
          .RuleFor(s => s.condition, conditions[rnd.Next(1, 3)])
          .Generate()

)
            );
*/