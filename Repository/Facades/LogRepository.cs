using DBEntity;
using Repository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Facades
{
    public class LogRepository : ILogRepository
    {
        private readonly DBManager.AppContext db;
        public LogRepository(DBManager.AppContext context) => this.db = context;

        public IEnumerable<Log> All() => this.db.Logs.ToList<Log>();

        public bool Delete(Log target)
        {
            this.db.Remove(target);
            int result = this.db.SaveChanges();
            return result > 0;
        }

        public Log Find(long id) => this.db.Logs.Find(id);

        public Log Save(Log target)
        {
            this.db.Add(target);
            this.db.SaveChanges();
            return target;
        }

        public Log Update(Log target)
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
