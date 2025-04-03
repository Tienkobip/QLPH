using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository.IRepository;
using QuanLyPhongHoc.UserAccount.IUserAccount;

namespace QuanLyPhongHoc.UserAccount
{
    public class AccountAuth : IUserAccount.IAccountAuth
    {
        private readonly IUnitOfWork unit;
        private readonly ICurrentAccount currentUser;

        public AccountAuth(IUnitOfWork _unit, ICurrentAccount _currentUser)
        {
            unit = _unit;
            currentUser = _currentUser;
        }
        public bool Login(string userName, string password)
        {
            var user = unit.User.Get(u => u.Name == userName);
            if(user == null || user.Password != password)
            {
                return false;
            }

            currentUser.CurrentUser = user;
            return true;
        }
    }
}
