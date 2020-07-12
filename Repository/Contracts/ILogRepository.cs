using DBEntity;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface ILogRepository
    {
        Log Find(long id);
        IEnumerable<Log> All();
        Log Save(Log target);
        Log Update(Log target);
        bool Delete(Log target);
    }
}
