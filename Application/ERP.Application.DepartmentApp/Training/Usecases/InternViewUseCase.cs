using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class InternViewUseCase : IInternPostViewUseCase
    {
        private ITrainingRepository _trainingRepository;

        public InternViewUseCase(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
           
        }

        public async Task<IEnumerable<JobPost>> GetAllJobPostExecuteAsync() => await _trainingRepository.GetAllJobPostAsync();

        public async Task<IEnumerable<JobPost>> GetobListOfSpecificCategoryExecuteAsync(string category) => await _trainingRepository.GetobListOfSpecificCategoryAsync(category);
    }
}
