using Erp.BL.DTOs.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Services.Users
{
    public interface IUserService
    {
        List<UserDto> GetAllUsers();

        UserDto GetUserById(Guid id);

        void CreateUser(UserDto user);

        void UpdateUser(Guid id, UserDto user);

        void DeleteUser(Guid id);
    }
}