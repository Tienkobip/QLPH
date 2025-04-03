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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IMaintainRequestManagementRepository RequestManagement { get; private set; }

        public IReportRepository Report { get; private set; }
        public IUser User { get; private set; }
        public IClassroomManagementRepository Classroom { get; private set; }
        
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            RequestManagement = new MaintainRequestManagementRepository(_db);
            Report = new ReportRepository(_db);
            User = new User(_db);
            Classroom = new ClassroomManagementRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
