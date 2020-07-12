using DBEntity;
using Repository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Facades
{
    public class LevelRepository : ILevelRepository
    {
        private readonly DBManager.AppContext db;
        public LevelRepository(DBManager.AppContext context) => this.db = context;

        public IEnumerable<Level> All() => this.db.Level.ToList();

        public bool Delete(Level target)
        {
            this.db.Remove(target);
            int result = this.db.SaveChanges();
            return result > 0;
        }

        public Level Find(long id) => this.db.Level.Find(id);

        public Level Save(Level target)
        {
            this.db.Add(target);
            this.db.SaveChanges();
            return target;
        }

        public Level Update(Level target)
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
