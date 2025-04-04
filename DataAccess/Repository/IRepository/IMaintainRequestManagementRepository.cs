using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IMaintainRequestManagementRepository : IRepository<MaintainRequest>
    {
        IEnumerable<string> GetRequestsList(Expression<Func<MaintainRequest, bool>>? filter = null);
        void Update(MaintainRequest obj);
    }
}
