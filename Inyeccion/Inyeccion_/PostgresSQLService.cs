using System;
namespace Inyeccion_
{
    public class PostgresSQLService : DBService
    {
        public PostgresSQLService()
        {
        }

        public void query()
        {
            Console.WriteLine("Ejecutando Query en PostgresSql");
        }
    }
}
