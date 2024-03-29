﻿using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class StudentRequestUseCase : IStudentRequestCreateUseCase
    {
        private ITrainingRepository _trainingRepository;

        public StudentRequestUseCase(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
            
        }

        public async Task ExecuteAsync(StudentRequest studentRequest)
        {
            await _trainingRepository.SendStudentRequestAsync(studentRequest);

        }
    }
}
