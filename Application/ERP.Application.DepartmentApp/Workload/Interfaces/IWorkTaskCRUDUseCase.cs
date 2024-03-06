using ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Workload.Interfaces
{
    public interface IWorkTaskCRUDUseCase
    {
        Task WorkTaskAddExecuteAsync(WorkingTask workingTask);
        Task WorkTaskRemoveExecuteAsync(WorkingTask workingTask);

        Task WorkTaskUpdateExecuteAsync(WorkingTask workingTask);

    }
}
