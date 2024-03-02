using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Interfaces
{
    public interface IInternPostViewUseCase
    {
        Task<IEnumerable<JobPost>> GetAllJobPostExecuteAsync();
        Task<IEnumerable<JobPost>> GetobListOfSpecificCategoryExecuteAsync(string category);

    }
}
