using Programming_Blog.CoreLayer.DTOs.User;
using Programming_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.CoreLayer.Services.Users
{
   public interface IUserService
    {
        OperationResult RegisterUser(UserRegisterDto registerDto);
    }
}
