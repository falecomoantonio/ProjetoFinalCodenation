using DBEntity;
using Repository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Facades
{
    public class EnviromentRepository : IEnviromentRepository
    {
        private readonly DBManager.AppContext db;

        public EnviromentRepository(DBManager.AppContext context) => this.db = context;

        public IEnumerable<Enviroment> All() => this.db.Enviroment.ToList<Enviroment>();

        public bool Delete(Enviroment target)
        {
            this.db.Remove(target);
            int result = this.db.SaveChanges();
            return result > 0;
        }

        public Enviroment Find(long id) => this.db.Enviroment.Find(id);

        public Enviroment Save(Enviroment target)
        {
            this.db.Add(target);
            this.db.SaveChanges();
            return target;
        }

        public Enviroment Update(Enviroment target)
        {
            if(!target.Id.HasValue)
            {
                return Save(target);
            }

            this.db.Update(target);
            this.db.SaveChanges();
            return target;
        }
    }
}
