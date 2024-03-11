using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.Interfaces.Scheduling_Lab
{
    public interface  IGetScheduleLabUseCase
    {
        Task<IEnumerable<Booking_Lab>> GetAppointmentsAsync();
    }
}
