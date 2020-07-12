using Repository;
using System;
using System.Linq;

namespace ConsoleManagerr
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            var repo = new UnitOfWork();

            System.Collections.Generic.IEnumerable<DBEntity.Enviroment> enviroments = repo.Enviroment.All();
            total = enviroments.Count();

            Console.WriteLine($"-- {total} de Ambientes -----------");
            foreach (DBEntity.Enviroment env in enviroments)
            {
                Console.WriteLine($"ID = {env.Id.Value} - Name = {env.Name} - Description = {env.Description}");
            }
            Console.WriteLine("------------------------------------\n");


            System.Collections.Generic.IEnumerable<DBEntity.Level> levels = repo.Level.All();
            total = levels.Count();
            Console.WriteLine($"-- {total} de Níveis --------------");
            foreach (DBEntity.Level level in levels)
            {
                Console.WriteLine($"ID = {level.Id.Value} - Name = {level.Name} - Description = {level.Description}");
            }
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
