using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training
{
    public interface ITrainingRepository
    {
       Task SendStudentRequestAsync (StudentRequest studentRequest);
        Task AddJobPostAsync(JobPost jobPost);

        Task RemoveJobPostAsync(JobPost jobPost);

        Task EditJobPostAsync(JobPost jobPost);

        Task<IEnumerable<JobPost>> GetAllJobPostAsync();

        Task<IEnumerable<JobPost>> GetobListOfSpecificCategoryAsync(string category);

        Task<IEnumerable<StudentRequest>> GetAllTrainingRequestsAsync(string name);

    }
}
