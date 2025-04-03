using DataAccess.Repository.IRepository;
using DataModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongHoc.MaintainRequestManagement
{
    public class MaintainValidCheck
    {
        private readonly IUnitOfWork unit;
        public MaintainValidCheck(IUnitOfWork _unit)
        {
            unit = _unit;
        }
        public bool IsValid(MaintainRequest request, out string dataInvalid, out string errorMessage)
        {
            if (string.IsNullOrEmpty(request.Description))
            {
                dataInvalid = "description";
                errorMessage = "Hãy điền thông tin chi tiết cho ban bảo trì hiểu thêm";
                return false;
            }

            if(unit.Classroom.Get(rq => rq.ID == request.ClassroomID) == null)
            {
                dataInvalid = "classroomid";
                errorMessage = "Mã lớp không tồn tại.";
                return false;
            }

            dataInvalid = "";
            errorMessage = "";
            return true;
        }
    }
}
