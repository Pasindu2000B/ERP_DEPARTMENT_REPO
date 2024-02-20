using System;
using ERP.Application.DepartmentApp.Labs.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP.Domain.Core.Entity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using ERP.Repository.PgSql.Migrations;

namespace ERP.Repository.PgSql.Department.Lab
{
    public class LabRepositoryPgSql : ILabRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;
        public LabRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }

        public Task AddLabEquipmentAsync(LabEquipment labEquipment)
        {
            using var _context = _factory.CreateDbContext();
            _context.LabEquipments.Add(labEquipment);
            _context.SaveChanges();
            return Task.CompletedTask;


        }

        public Task AddLabEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLabEquipmentAsync(LabEquipment labEquipment)
        {
            using var context = _factory.CreateDbContext(); 
            context.LabEquipments.Remove(labEquipment);
            context.SaveChanges();
            return Task.CompletedTask;
          
        }

        public Task DeleteLabEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditLabEquipmentAsync(LabEquipment labEquipment)
        {
            throw new NotImplementedException();
        }

        public Task EditLabEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LabEquipment>> GetAllLabEquipmentAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.LabEquipments.ToListAsync();

        }

        public Task<LabEquipment> GetLabEquipmentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
