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
    public class EditLabEquipmentUseCase : IEditLabEquimentUsecase
    {
        private readonly ILabRepository _labRepository;

        public EditLabEquipmentUseCase(ILabRepository labRepository)
        {
            _labRepository = labRepository;

        }

        public async Task ExcuteAsync(LabEquipment labEquipment)
        {
            await _labRepository.EditLabEquipmentAsync(labEquipment);
        }



    }
}
