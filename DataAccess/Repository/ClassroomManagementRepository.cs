using DataAccess.Data;
using DataAccess.Repository.IRepository;
using DataAccess.Utility;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    class ClassroomManagementRepository : Repository<Classroom>, IClassroomManagementRepository
    {

        private readonly ApplicationDbContext _db;
        public ClassroomManagementRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<string> GetInfoList()
        {
            return _db.Classrooms.Select(obj => 
            $"{obj.ID}," +
            $"{obj.Name}," +
            $"{EnumHelper.GetEnumDescription(obj.Type)}," +
            $"{EnumHelper.GetEnumDescription(obj.Status)}," +
            $"{obj.Capacity}," +
            $"{obj.Location}").ToList();
        }

        public void Update(DataModels.Classroom obj)
        {
            var requestFromDb = _db.Classrooms.FirstOrDefault(u => u.ID == obj.ID);
            if (requestFromDb != null)
            {
                requestFromDb.ID = obj.ID;
                requestFromDb.Name = obj.Name;
                requestFromDb.Type = obj.Type;
                requestFromDb.Status = obj.Status;
                requestFromDb.Capacity = obj.Capacity;
                requestFromDb.Location = obj.Location;
            }
        }
    }
}
