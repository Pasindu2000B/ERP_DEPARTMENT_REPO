using ERP.Application.DepartmentApp.Workload.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Workload.UseCases
{
    public class WorkTaskCrudUseCase : IWorkTaskCRUDUseCase
    {
        private readonly WorkLoadRepository _workloadRepository;
        public WorkTaskCrudUseCase(WorkLoadRepository workLoadRepository)
        {
            _workloadRepository = workLoadRepository; 
        }
        public async Task WorkTaskAddExecuteAsync(WorkingTask workingTask)
        {
           await _workloadRepository.AddWorkTaskAsync(workingTask);
        }

        public async Task WorkTaskRemoveExecuteAsync(WorkingTask workingTask)
        {
            await _workloadRepository.DeleteWorkTaskAsync(workingTask);
        }

        public async Task WorkTaskUpdateExecuteAsync(WorkingTask workingTask)
        {
            await _workloadRepository.UpdateWorkTaskAsync(workingTask);
        }
    }
}
