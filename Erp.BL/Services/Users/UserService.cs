using Erp.BL.DTOs.UserDto;
using Erp.DAL.Data.Models;
using Erp.DAL.Data.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _repo;

        public UserService(IUsersRepository repo)
        {
            _repo = repo;
        }

        public void CreateUser(UserDto userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
            };

            _repo.Insert(user);
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAllUsers()
        {
            var users = _repo.GetUsers();
            return users.Select(x => new UserDto
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
            }).ToList();
        }

        public UserDto GetUserById(Guid id)
        {
            var entity = _repo.GetById(id);
            if (entity == null) return null;

            return new UserDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email
            };
        }

        public void UpdateUser(Guid id, UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}