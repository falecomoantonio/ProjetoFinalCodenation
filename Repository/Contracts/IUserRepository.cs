using DBEntity;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        User Find(long id);
        IEnumerable<User> All();
        User Save(User target);
        User Update(User target);
        bool Delete(User target);
        User Register(string name, string email, string nickname, string password);
    }
}
