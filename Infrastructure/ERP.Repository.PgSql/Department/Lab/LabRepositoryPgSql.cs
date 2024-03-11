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
using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;

namespace ERP.Repository.PgSql.Department.Lab
{
    public class LabRepositoryPgSql : ILabRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;
        public LabRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
           
        }
        //comment
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
            using var _context = _factory.CreateDbContext();
            var elabequipment = _context.LabEquipments.FirstOrDefault(x => x.LabEquipmentID == labEquipment.LabEquipmentID);
            if (elabequipment != null)
            {
                _context.LabEquipments.Remove(elabequipment);
                _context.SaveChanges();
            }
            return Task.CompletedTask;

        }

        public Task DeleteLabEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditLabEquipmentAsync(LabEquipment labEquipment)
        {
            using var _context = _factory.CreateDbContext();
            var elabequipment = _context.LabEquipments.FirstOrDefault(x=>x.LabEquipmentID == labEquipment.LabEquipmentID);
            if(elabequipment != null)
            {
                elabequipment.LabEquipmentName = labEquipment.LabEquipmentName;
                elabequipment.LabSpaceId = labEquipment.LabSpaceId;
                elabequipment.Avaialability = labEquipment.Avaialability;
                elabequipment.condition = labEquipment.condition;
                _context.SaveChanges();
            }
            return Task.CompletedTask;
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
