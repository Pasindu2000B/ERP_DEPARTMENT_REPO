using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.Interfaces
{
    public interface IAddGraduateUseCase
    {
        Task ExecuteAsync(Graduate graduate);
        
    }
}
//Comment to check the connection of dev2