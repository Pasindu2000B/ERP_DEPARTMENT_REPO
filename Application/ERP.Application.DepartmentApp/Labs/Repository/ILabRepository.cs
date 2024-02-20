using ERP.Domain.Core.Entity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.Repository
{
    public interface ILabRepository
    {
        Task<IEnumerable<LabEquipment>> GetAllLabEquipmentAsync(string name);

       
        Task AddLabEquipmentAsync(int id);

        Task DeleteLabEquipmentAsync(int id);

        Task EditLabEquipmentAsync(int id);

        Task<LabEquipment> GetLabEquipmentById(int id);
        Task AddLabEquipmentAsync(LabEquipment labEquipment);
    }
}
