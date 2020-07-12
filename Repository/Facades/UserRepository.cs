using Common;
using DBEntity;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Facades
{
    public class UserRepository : IUserRepository
    {
        private readonly DBManager.AppContext db;
        public UserRepository(DBManager.AppContext context) => this.db = context;

        public IEnumerable<User> All() => this.db.User.ToList<User>();

        public bool Delete(User target)
        {
            this.db.Remove(target);
            int result = this.db.SaveChanges();
            return result > 0;
        }

        public User Find(long id) => this.db.User.Find(id);

        public User Register(string name, string email, string nickname, string password)
        {
            try
            {
                User user = new User
                {
                    Email = email.Trim(),
                    Name = name.Trim(),
                    Username = nickname.Trim().ToLower(),
                    Password = PasswordUtil.Hash(password),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                return Save(user);
            }
            catch
            {
                return null;
            }
        }

        public User Save(User target)
        {
            this.db.Add(target);
            this.db.SaveChanges();
            return target;
        }

        public User Update(User target)
        {
            if (!target.Id.HasValue)
            {
                return Save(target);
            }

            this.db.Update(target);
            this.db.SaveChanges();
            return target;
        }
    }
}
