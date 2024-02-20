using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.Repository;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.UseCases
{
    public class AddGraduateUseCase : IAddGraduateInterface
    {
        private readonly IGraduateRepository _GraduateRepository;

        public AddGraduateUseCase(IGraduateRepository graduateRepository)
        {
            _GraduateRepository = graduateRepository;
        }

        public async Task ExcuteAsync(Graduate graduate)
        {
            await _GraduateRepository.AddGraduateAsync(graduate);
        }

        
    }
}
