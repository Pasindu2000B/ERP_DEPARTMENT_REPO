using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Repsitory;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases.CRUD
{
    public class AddJobPostingUseCase : IAddJobPostingUseCase
    {
        private readonly TrainingRepository _trainingRepository;

        public AddJobPostingUseCase(TrainingRepository trainingRepository) {

            _trainingRepository = trainingRepository;
        
        
        }
    

        public async Task ExecuteAsync(JobPost jobPost)
        {
            await _trainingRepository.AddJobPostAsync(jobPost);

        }
    }
}
