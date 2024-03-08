using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.UseCases
{
    public class GetAllCompanyNamesUseCase:IGetAllCompanyNamesUseCase
    {
        private readonly IGraduateRepository _graduateRepository;

        public GetAllCompanyNamesUseCase(IGraduateRepository graduateRepository)
        {
            _graduateRepository = graduateRepository;
        }

        public async Task<List<string>> ExecuteAsync()
        {
            return await _graduateRepository.GetAllCompaniesAsync();
        }
    }
}
