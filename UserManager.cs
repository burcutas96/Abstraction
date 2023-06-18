using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public class UserManager : IUserValidateService, IUserProcessService
    {
        public List<User> Users { get; set; }

        public void CreateUser(User user)
        {
            //iş kodları...
        }

        public void RemoteUser(int userId)
        {
            //iş kodları...
        }

        public bool ValidateUser(User user)
        {
            return true;
        }



        //UserManager sınıfına ait metotlar...
        public void UpdateUser(User user)
        {
            //İş kodları
        }
    }
}
