using ERP.Application.DepartmentApp.Graduates.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Department.Graduate
{
    public class GraduateRepositoryPgSql : IGraduateRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public GraduateRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }


        public Task AddGraduateAsync(Domain.Core.Entity.DepartmentEntity.GraduatesEntity.Graduate graduate)
        {
            using var _context = _factory.CreateDbContext();
            _context.Graduates.Add(graduate);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Domain.Core.Entity.DepartmentEntity.GraduatesEntity.Graduate>> GetAllGraduateAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Graduates.ToListAsync();
        }

        public Task EditGraduateAsync(Domain.Core.Entity.DepartmentEntity.GraduatesEntity.Graduate graduate)
        {
            using var _context = _factory.CreateDbContext();
            var egraduate = _context.Graduates.FirstOrDefault(x => x.GraduateID == graduate.GraduateID);

            if (egraduate != null)
            {
                egraduate.GraduateName = graduate.GraduateName;
                egraduate.GraduateCompany = graduate.GraduateCompany;
                egraduate.GraduateDescription = graduate.GraduateDescription;
                egraduate.GraduateContactNo = graduate.GraduateContactNo;
                _context.SaveChanges();
            }
            return Task.CompletedTask;
        }
    }
}
