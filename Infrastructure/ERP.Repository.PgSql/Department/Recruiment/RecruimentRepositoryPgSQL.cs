using ERP.Application.DepartmentApp.Recruiments;
using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.Recruiment
{
    public class RecruimentRepositoryPgSQL : IRecrumentRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

     

        public RecruimentRepositoryPgSQL(IDbContextFactory<PgSqlDbContext>factory)
        {
            _factory=factory;
        }

        public Task AddJobpostAsync(RecruimentJobPost jobpost)
        {
            using var _context = _factory.CreateDbContext();
            _context.RecruimentJobs.Add(jobpost);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task DeleteJobpostAsync(RecruimentJobPost recruimentJobPost)
        {
            using var _context = _factory.CreateDbContext();
            var job = _context.RecruimentJobs.FirstOrDefault(x => x.JobId == recruimentJobPost.JobId);
            _context.Remove(job);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateJobpostAsync(RecruimentJobPost recruimentJobPost)
        {
            using var _context = _factory.CreateDbContext();
            var job = _context.RecruimentJobs.FirstOrDefault(x => x.JobId == recruimentJobPost.JobId);
            if (job != null)
            {
                job.Title = recruimentJobPost.Title;
                job.Description = recruimentJobPost.Description;
                job.QualificationsRequired = recruimentJobPost.QualificationsRequired;
                job.CreatedDate = recruimentJobPost.CreatedDate;
                job.DeadlineDate = recruimentJobPost.DeadlineDate;
                job.Status = recruimentJobPost.Status;

            }

            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
