using DBEntity;
using DBManager;
using Repository.Contracts;
using Repository.Facades;
using System;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBManager.AppContext context;

        private IUserRepository repoUser;
        private IEnviromentRepository repoEnv;
        private ILogRepository repoLog;
        private ILevelRepository repoLevel;

        public UnitOfWork() => this.context = new DBManager.AppContext();


        public IUserRepository User
        {
            get
            {
                if (repoUser is null)
                {
                    repoUser = new UserRepository(this.context);
                }

                return repoUser;
            }
        }

        public IEnviromentRepository Enviroment
        {
            get
            {
                if (repoEnv is null)
                {
                    repoEnv = new EnviromentRepository(this.context);
                }

                return repoEnv;
            }
        }

        public ILogRepository Log
        {
            get
            {
                if (repoLog is null)
                {
                    repoLog = new LogRepository(this.context);
                }

                return repoLog;
            }
        }

        public ILevelRepository Level
        {
            get
            {
                if (repoLevel is null)
                {
                    repoLevel = new LevelRepository(this.context);
                }

                return repoLevel;
            }
        }
    }
}
