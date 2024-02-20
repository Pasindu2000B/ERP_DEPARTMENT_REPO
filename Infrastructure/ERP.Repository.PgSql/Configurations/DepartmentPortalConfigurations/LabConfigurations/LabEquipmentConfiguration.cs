using Bogus;
using ERP.Domain.Core.Entity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.LabConfigurations
{
    internal class LabEquipmentConfiguration : IEntityTypeConfiguration<LabEquipment>
    {
        public void Configure(EntityTypeBuilder<LabEquipment> builder)
        {
            string[] conditions = { "good", "medium", "bad" };
            Random rnd = new Random();


            builder.HasData(

               Enumerable.Range(1, 3).Select(
                   index => new Faker<LabEquipment>()
                         .RuleFor(s => s.LabEquipmentID, index + 1000)
                         .RuleFor(s => s.LabEquipmentName, f => f.Name.FirstName())
                         .RuleFor(s => s.condition, conditions[rnd.Next(1,3)])
                         .Generate()

               )
            );




        }

       
    }
}


/*  internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {



            builder.HasData(

               Enumerable.Range(1, 3).Select(
                   index => new Faker<Student>()
                         .RuleFor(s => s.StudentId, index + 1000)
                         .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                         .RuleFor(s => s.LastName, f => f.Name.LastName())
                         .RuleFor(s => s.Email, (f,u) => f.Internet.Email(u.FirstName,u.LastName))
                         .RuleFor(s => s.RegistrationNum, f => $"EG/{f.Random.Int(2020,2023)}/{f.Random.Int(1000, 9999)}").Generate()
                         
               )
            );

              
           

        }
    } */