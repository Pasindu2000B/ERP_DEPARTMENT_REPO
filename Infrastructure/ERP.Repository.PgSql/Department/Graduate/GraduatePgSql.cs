using ERP.Application.DepartmentApp.Graduates.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.Graduate
{
    public class GraduatePgSql : IGraduateRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;
        public GraduatePgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }

        public Task AddGraduateAsync(Domain.Core.Entity.DepartmentEntity.GraduatesEntity.Graduate graduate)
        {
            using var _context = _factory.CreateDbContext();
            _context.graduates.Add(graduate);
            _context.SaveChanges();
            return Task.CompletedTask;

        }
    }
}
