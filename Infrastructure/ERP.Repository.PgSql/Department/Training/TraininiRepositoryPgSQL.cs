using ERP.Application.DepartmentApp.Training;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
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

        public Task AddJobPostAsync(JobPost jobPost)
        {
            using var _context=_factory.CreateDbContext();  
            _context.JobPosts.Add(jobPost);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task EditJobPostAsync(JobPost jobPost)
        {
           using var _context = _factory.CreateDbContext();
            var job = _context.JobPosts.FirstOrDefault(x=>x.Id == jobPost.Id);
            if(job != null)
            {
                job.CompanyName = jobPost.CompanyName;
                job.InternPosition = jobPost.InternPosition;
                job.JobDescriptionLink = jobPost.JobDescriptionLink;
                job.CompanyEmail = jobPost.CompanyEmail;
            }

            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<JobPost>> GetAllJobPostAsync()
        {
            using var _context = _factory.CreateDbContext();
            return await _context.JobPosts.ToListAsync();
        }

        public async Task<IEnumerable<JobPost>?> GetobListOfSpecificCategoryAsync(string category)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.JobPosts.FirstOrDefaultAsync(x => x.Category == category) as IEnumerable<JobPost>;

        }

        public Task RemoveJobPostAsync(JobPost jobPost)
        {
            using var _context = _factory.CreateDbContext();
            var job = _context.JobPosts.FirstOrDefault(x => x.Id == jobPost.Id);
            _context.Remove(job);
            _context.SaveChanges();
            return Task.CompletedTask;
             

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
