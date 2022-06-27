using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Interfaces
{
   public interface IJWTMangerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);

    }
}
