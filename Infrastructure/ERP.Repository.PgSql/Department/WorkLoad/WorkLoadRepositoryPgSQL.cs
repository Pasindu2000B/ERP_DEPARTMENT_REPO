using ERP.Application.DepartmentApp.Workload;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.WorkLoad
{
    public class WorkLoadRepositoryPgSQL : WorkLoadRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

       
        public WorkLoadRepositoryPgSQL(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
            
        }
        public Task AddWorkTaskAsync(WorkingTask workloadTask)
        {
            using var _context = _factory.CreateDbContext();
            _context.WorkingTasks.Add(workloadTask);
            _context.SaveChanges();
            return Task.CompletedTask;

        }

        public Task DeleteWorkTaskAsync(WorkingTask workingTask)
        {
            using var _context = _factory.CreateDbContext();
            var job = _context.WorkingTasks.FirstOrDefault(x => x.WorkingTaskId==workingTask.WorkingTaskId);
            _context.Remove(job);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateWorkTaskAsync(WorkingTask workingTask)
        {
            using var _context = _factory.CreateDbContext();
            var workingTask1 = _context.WorkingTasks.FirstOrDefault(x => x.WorkingTaskId == workingTask.WorkingTaskId);
            if (workingTask1 != null)
            {
                workingTask1.TeacherId= workingTask.TeacherId;
                workingTask1.Decription=workingTask.Decription;
                workingTask1.Assign= workingTask.Assign;
                workingTask1.TimeAllocated= workingTask.TimeAllocated;
                
            }

            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
