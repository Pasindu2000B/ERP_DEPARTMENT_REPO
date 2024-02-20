using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Repsitory;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases.CRUD
{
    public class EditJobPostingUseCase : IEditJobPostUseCase
    {
        private TrainingRepository _trainingRepository;

        public EditJobPostingUseCase(TrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
            
        }
        public async Task ExcuteAsync(JobPost jobPost)
        {
            await _trainingRepository.EditJobPostAsync(jobPost);
            
        }
    }
}
