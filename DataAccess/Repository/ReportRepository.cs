using DataAccess.Data;
using DataAccess.Repository.IRepository;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    class ReportRepository : Repository<Report>, IReportRepository
    {
        private readonly ApplicationDbContext db;
        public ReportRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

        public void Update(Report obj)
        {
            var reportFromDb = db.Reports.FirstOrDefault(u => u.ID == obj.ID);
            if (reportFromDb != null)
            {
                reportFromDb.Date = obj.Date;
                reportFromDb.User = obj.User;
                reportFromDb.Type = obj.Type;
                reportFromDb.Content = obj.Content;
            }

        }
    }
}
