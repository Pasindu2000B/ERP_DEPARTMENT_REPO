using ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Workload
{
    public interface WorkLoadRepository
    {
        Task AddWorkTaskAsync(WorkingTask workloadTask);
        Task UpdateWorkTaskAsync(WorkingTask workingTask);

        Task DeleteWorkTaskAsync(WorkingTask workingTask);

    }
}
