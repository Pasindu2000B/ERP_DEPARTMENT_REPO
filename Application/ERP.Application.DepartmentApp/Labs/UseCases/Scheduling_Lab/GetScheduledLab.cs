using ERP.Application.DepartmentApp.Labs.Interfaces.Scheduling_Lab;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.UseCases.Scheduling_Lab
{
    public class GetScheduledLab : IGetScheduleLabUseCase
    {
        private readonly ILabRepository _labRepository;
        public GetScheduledLab(ILabRepository labRepository)
        {
            _labRepository = labRepository;
            
        }
        public async Task<IEnumerable<Booking_Lab>> GetAppointmentsAsync() => await _labRepository.GetAppointmentsAsync();
    }
}
