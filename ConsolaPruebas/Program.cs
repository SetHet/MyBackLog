using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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


            db.NonQuery("Insert into plataforma values (0, 'Steam', 'PC Master Race')");

            SQLiteDataReader reader = db.Select("Select * from progresion");

            try
            {
                if (reader != null && reader.HasRows)
                {
                    Console.WriteLine("Progesion List");
                    while (reader.Read())
                    {
                        Console.WriteLine("ID: {0} - Nombre: {1} - Descripcion: {2}", reader["id_progresion"], reader["nombre_estado"], reader["descripcion"]);
                    }
                }
                else
                    Console.WriteLine("Progesion List not work");
            }
            catch(Exception ex)
            {
                Console.WriteLine(">> EXCEPTION: " + ex.Message);
            }


            Console.Read();
        }
    }
}
