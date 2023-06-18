using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public interface IUserValidateService
    {
        bool ValidateUser(User user);
    }
}
