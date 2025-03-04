using DataAccess.Data;
using DataAccess.Repository.IRepository;
using DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MaintainRequestManagementRepository : Repository<MaintainRequest>, IMaintainRequestManagementRepository
    {
        private readonly ApplicationDbContext _db;
        public MaintainRequestManagementRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<string> GetRequestsList()
        {
            return _db.MaintainRequests
                      .Include(obj => obj.User) 
                      .Select(obj =>
                          $"{obj.ID}, {obj.User.Name}, {obj.IssueType}, {obj.IssueStatus}, EDIT, DELETE"
                      ).ToList();
        }

        public void Update(MaintainRequest obj)
        {
            _db.MaintainRequests.Update(obj);
        }
    }
}
