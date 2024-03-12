using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class FileDownLoadUseCase : IFileDownLoadUseCase
    {
        private readonly ITrainingRepository _trainingRepository;

        public FileDownLoadUseCase(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
            
        }

        public Task<FileUpload> DownloadFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}
