using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUser : IRepository<DataModels.User>
    {
        void Update(DataModels.User obj);
    }
}
