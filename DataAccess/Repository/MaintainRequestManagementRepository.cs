﻿using DataAccess.Data;
using DataAccess.Repository.IRepository;
using DataAccess.Utility;
using DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MaintainRequestManagementRepository : Repository<MaintainRequest>, IMaintainRequestManagementRepository
    {
        private readonly ApplicationDbContext db;
        public MaintainRequestManagementRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

        public IEnumerable<string> GetRequestsList(Expression<Func<MaintainRequest, bool>>? filter = null)
        {
            IQueryable<MaintainRequest> query = dbSet.Include(obj => obj.User);

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.Select(obj =>
                          $"{obj.ID}," +
                          $"{obj.User.Name}," +
                          $"{EnumHelper.GetEnumDescription(obj.IssueType)}," +
                          $"{EnumHelper.GetEnumDescription(obj.IssueStatus)}"
                      ).ToList();
        }

        public void Update(MaintainRequest obj)
        {
            var requestFromDb = db.MaintainRequests.FirstOrDefault(u => u.ID == obj.ID);
            if (requestFromDb != null)
            {
                requestFromDb.UserID = obj.UserID;
                requestFromDb.ClassroomID = obj.ClassroomID;
                requestFromDb.Date = DateTime.Now;
                requestFromDb.IssueStatus = obj.IssueStatus;
                requestFromDb.IssueType = obj.IssueType;
                requestFromDb.Description = obj.Description;
            }
        }
    }
}
