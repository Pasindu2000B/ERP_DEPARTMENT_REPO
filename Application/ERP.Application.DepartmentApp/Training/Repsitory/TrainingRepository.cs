using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Repsitory
{
    public interface TrainingRepository
    {
        Task AddJobPostAsync(JobPost jobPost);
        Task EditJobPostAsync (JobPost jobPost);

    }
}
