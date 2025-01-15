using CodeYad_Blog.CoreLayer.Utilities;
using Programming_Blog.CoreLayer.DTOs.User;
using Programming_Blog.CoreLayer.Utilities;
using Programming_Blog.DataLayer.Context;
using Programming_Blog.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Programming_Blog.DataLayer.Entities.Role;

namespace Programming_Blog.CoreLayer.Services.Users
{
    public class UserService : IUserService
    {
        private readonly BlogwContext _context;
        public UserService(BlogwContext context)
        {
            _context = context;
        }

        public OperationResult RegisterUser(UserRegisterDto registerDto)
        {
            if (string.IsNullOrEmpty(registerDto.UserName))
            {
                return OperationResult.Error("Enter the username");
            }
            if (string.IsNullOrEmpty(registerDto.FullName))
            {
                return OperationResult.Error("Enter the FullName");
            }
            if (string.IsNullOrEmpty(registerDto.Password))
            {
                return OperationResult.Error("Enter the password");

            }
            if (string.IsNullOrEmpty(registerDto.Password) || registerDto.Password.Length < 8 || registerDto.Password.Length >16)
            {
                return OperationResult.Error("Password must be more than 8 characters.");

            }


            var isFullNameExist = _context.Users.Any(u => u.UserName == registerDto.UserName);
            if (isFullNameExist)
            {
              return  OperationResult.Error("Duplicate username");

            }
            var PasswordHash = registerDto.Password.EncodeToMd5();
            _context.Users.Add(new User()
            {
                UserName = registerDto.UserName,
                FullName = registerDto.UserName,
                IsDelete = false,
                Password = PasswordHash,
                CreationDate = DateTime.Now,
            });
            _context.SaveChanges();
          return  OperationResult.Success();
        }
    }
}
