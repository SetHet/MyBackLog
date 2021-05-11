using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            
            BD.DataBase.DeleteDataBase("myBackLogDataBase.sqlite3");
            Console.ReadLine();
            BD.DataBase db = new BD.DataBase();


            db.LoadStatement("Create table biz (column1 text primary key);\nCreate table biz2 (column1 text primary key);");


            Console.Read();
        }
    }
}
