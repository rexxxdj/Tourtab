using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourtab.Classes
{
    static class StaticMembers
    {
        /*Глобальная строка подключения. Знаю, тот еще костыль.*/
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\TourtabDb.mdf;Integrated Security=True";
    }
}
