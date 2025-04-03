using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;

namespace QuanLyPhongHoc.UserAccount.IUserAccount
{
    public interface ICurrentAccount
    {
        User? CurrentUser { get; set; }
    }
}
