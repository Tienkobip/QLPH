using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //ADD TABLE
        IUser User { get; }
        IMaintainRequestManagementRepository RequestManagement { get; }
        IReportRepository Report { get; }
        IClassroomManagementRepository Classroom { get; }
        void Save();
    }
}
