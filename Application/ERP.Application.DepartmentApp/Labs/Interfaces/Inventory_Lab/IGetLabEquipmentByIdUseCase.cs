using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab
{
    public interface IGetLabEquipmentByIdUseCase
    {
        Task ExecuteAsync(int id);
    }
}
