using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DAL.Data.Models;

namespace Erp.DAL.Data.Repositories.Users
{
    public interface IUsersRepository
    {
        List<User> GetUsers();

        User GetById(Guid id);

        List<User> GetByProject(Guid projectId);

        void Update(Guid id, User user);

        void Delete(Guid id);

        void Insert(User user);
    }
}