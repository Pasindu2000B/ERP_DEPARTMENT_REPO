using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Interfaces
{
    public interface IInternPostUseCase
    {
        Task AddExecuteAsync(JobPost jobPost);
        Task EditExecuteAsync(JobPost jobPost);

        Task DeleteExecuteAsync(JobPost jobPost);

      
    }
}
