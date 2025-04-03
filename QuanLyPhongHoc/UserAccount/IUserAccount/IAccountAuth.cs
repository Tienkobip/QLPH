using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongHoc.UserAccount.IUserAccount
{
    public interface IAccountAuth
    {
        bool Login(string userName, string password);
    }
}
