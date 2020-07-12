using DBEntity;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IEnviromentRepository
    {
        Enviroment Find(long id);
        IEnumerable<Enviroment> All();
        Enviroment Save(Enviroment target);
        Enviroment Update(Enviroment target);
        bool Delete(Enviroment target);
    }
}
