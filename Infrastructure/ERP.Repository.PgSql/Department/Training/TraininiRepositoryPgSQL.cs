using ERP.Application.DepartmentApp.Training;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.Training
{
    public class TraininiRepositoryPgSQL : TrainingRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public TraininiRepositoryPgSQL(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
            
        }
        public Task SendStudentRequestAsync(StudentRequest studentRequest)
        {
            using var _context = _factory.CreateDbContext();
            _context.StudentRequests.Add(studentRequest);
            _context.SaveChanges();
            return Task.CompletedTask;

        }
    }
}
