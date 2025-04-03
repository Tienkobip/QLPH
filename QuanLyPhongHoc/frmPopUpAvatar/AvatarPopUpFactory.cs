
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongHoc.frmPopUpAvatar
{
    public class AvatarPopUpFactory : IAvatarPopUpFactory.IAvatarPopUpFactory
    {
        private readonly IServiceProvider serviceProvider;
        public AvatarPopUpFactory(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }

        public frmPopUpAvatar Create(Image avatar)
        {
            return new frmPopUpAvatar(avatar, serviceProvider);
        }
    }
}
