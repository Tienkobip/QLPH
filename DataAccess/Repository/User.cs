using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class User : Repository<DataModels.User>, IUser
    {
        private readonly ApplicationDbContext db;

        public User(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }
        public void Update(DataModels.User obj)
        {
            var userFromDb = db.Users.FirstOrDefault(u => u.ID == obj.ID);

            if (userFromDb != null)
            {
                userFromDb.Name = obj.Name;
                userFromDb.Password = obj.Password;
                userFromDb.Email = obj.Email;
                userFromDb.Phone = obj.Phone;
            }

        }
    }
}
