using System;
namespace Inyeccion_
{
    public class Datatabase
    {
        DBService dbService;

        public Datatabase(DBService dbService)
        {
            this.dbService = dbService;
        }

        public void query() {

            dbService.query();
        }
    }
}
