using Repository.Contracts;
using Repository.Facades;

namespace Repository
{
    public interface IUnitOfWork
    {
        public IUserRepository User { get; }

        public IEnviromentRepository Enviroment { get; }

        public ILogRepository Log { get; }

        public ILevelRepository Level { get; }
    }
}
