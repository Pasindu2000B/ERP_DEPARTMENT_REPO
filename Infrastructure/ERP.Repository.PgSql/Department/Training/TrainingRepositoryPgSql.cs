using ERP.Application.DepartmentApp.Training.Repsitory;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.Training
{
    public class TrainingRepositoryPgSql : TrainingRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;
        public TrainingRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }

        public Task AddJobPostAsync(JobPost jobPost)
        {
            using var _context = _factory.CreateDbContext();
            _context.JobPosts.Add(jobPost);
            _context.SaveChanges();
            return Task.CompletedTask;


        }

        public Task EditJobPostAsync(JobPost jobPost)
        {
            using var _context = _factory.CreateDbContext();
            int id = jobPost.JobPostId;
            JobPost Job=_context.JobPosts.Find(id);
            if(Job != null)
            {
                _context.JobPosts.Remove(Job);
                _context.SaveChanges() ;
                _context.JobPosts.Add(Job);
                _context.SaveChanges();
                return Task.CompletedTask;

            }
            else { return Task.CompletedTask; }

        }
    }
}
