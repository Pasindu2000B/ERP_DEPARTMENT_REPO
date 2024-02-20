using ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.UseCases.Inventor_Lab
{
    public class DeleteLabEquipmentUseCase : IDeleteLabEquipmentUseCase
    {
        private readonly ILabRepository _labRepository;

        public DeleteLabEquipmentUseCase(ILabRepository labRepository)
        {
            _labRepository = labRepository;

        }

        public Task ExcuteAsync(LabEquipment labEquipment)
        {
            throw new NotImplementedException();
        }
    }
}
