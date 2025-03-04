using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IMaintainRequestManagementRepository : IRepository<MaintainRequest>
    {
        IEnumerable<string> GetRequestsList();
        void Update(MaintainRequest obj);
    }
}
