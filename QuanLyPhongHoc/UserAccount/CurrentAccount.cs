using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using QuanLyPhongHoc.UserAccount.IUserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;

namespace QuanLyPhongHoc.UserAccount
{
    public class CurrentAccount : ICurrentAccount
    {
        DataModels.User? ICurrentAccount.CurrentUser { get ; set; }
    }
}
