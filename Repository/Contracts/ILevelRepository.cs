using DBEntity;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface ILevelRepository
    {
        Level Find(long id);
        IEnumerable<Level> All();
        Level Save(Level target);
        Level Update(Level target);
        bool Delete(Level target);
    }
}
