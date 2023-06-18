using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public interface IUserProcessService
    {
        void CreateUser(User user);
        void RemoteUser(int userId);
        List<User> Users { get; set; }
    }
}
