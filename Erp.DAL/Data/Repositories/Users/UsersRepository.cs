using Erp.DAL.Data.ContractorsContext;
using Erp.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DAL.Data.Repositories.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ErpContext db;

        public UsersRepository(ErpContext db)
        {
            this.db = db;
        }

        public void Delete(Guid id)
        {
            db.Users.Remove(GetById(id));
        }

        public User GetById(Guid id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetByProject(Guid projectId)
        {
            return db.Users.Where(e => e.Id == projectId).ToList();
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public void Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Update(Guid id, User user)
        {
            var current = GetById(id);
            if (current != null)
            {
                current.Name = user.Name;
                current.Email = user.Email;
                current.Role = user.Role;
                // add password later
                db.SaveChanges();
            }
        }
    }
}