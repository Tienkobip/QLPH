using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongHoc.frmPopUpAvatar.IAvatarPopUpFactory
{
    public interface IAvatarPopUpFactory
    {
        frmPopUpAvatar Create(Image avatar);
    }
}
