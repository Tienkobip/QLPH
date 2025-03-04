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
        private readonly ApplicationDbContext _db;
        public ReportRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Report obj)
        {
            _db.Reports.Update(obj);
        }
    }
}
