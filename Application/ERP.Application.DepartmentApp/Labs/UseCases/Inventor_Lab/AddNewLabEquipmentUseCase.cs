using ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Domain.Core.Entity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.UseCases.Inventor_Lab
{
    public class AddNewLabEquipmentUseCase : IAddLabEquipmentUseCase
    {
        private readonly ILabRepository _labRepository;

        public AddNewLabEquipmentUseCase(ILabRepository labRepository)
        {
            _labRepository = labRepository;
        }

        public async Task ExecuteAsync(LabEquipment labEquipment)
        {
            await _labRepository.AddLabEquipmentAsync(labEquipment);

        }

    }
}

