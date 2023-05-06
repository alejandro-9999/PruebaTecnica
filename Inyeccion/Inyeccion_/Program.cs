using System;

namespace Inyeccion_
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MySQLService mysql = new MySQLService();
            Datatabase db_1 = new Datatabase(mysql);
            db_1.query();



            PostgresSQLService postgres = new PostgresSQLService();
            Datatabase db_2 = new Datatabase(postgres);

            db_2.query();

        }
    }
}
