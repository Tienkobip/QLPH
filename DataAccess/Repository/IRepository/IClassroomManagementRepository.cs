using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IClassroomManagementRepository : IRepository<Classroom>
    {
        IEnumerable<string> GetInfoList();
        void Update(Classroom obj);
    }
}
