using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace BD
{
    public class DataBase
    {
        public string nameDB = "myBackLogDataBase.sqlite3";
        public string connectionString = "Data Source=database.sqlite3";

        public SQLiteConnection myConnection;

        public DataBase()
        {
            myConnection = new SQLiteConnection(connectionString);
            Console.WriteLine("Start Database" + "\nPath: " + Directory.GetCurrentDirectory());
           

            if (!File.Exists("./" + nameDB))
            {
                try
                {
                    SQLiteConnection.CreateFile(nameDB);
                    BD.SQLiteModel.CrearModelo(this);

                    System.Console.WriteLine(">> Creada la base de datos: " + nameDB + "\nPath: " + Directory.GetCurrentDirectory() + "\\" + nameDB);
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(">> ERROR: No se ha podido crear la base de datos\n" + ex.Message);
                }
            }
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public void DeleteDataBase()
        {
            File.Delete("./" + nameDB);
        }

        /// <summary>
        /// Carga todas las sentencias que se le ingresen.
        /// Sirve para realizar configuraciones.
        /// </summary>
        /// <param name="sentences"></param>
        public void LoadStatement(string sentences)
        {
            
        }

        /// <summary>
        /// Retorna los datos de un Select
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public SQLiteVirtualTable Select(string sentence)
        {
            return null;
        }

        /// <summary>
        /// Se utiliza con Insert y Update
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public bool NonQuery(string sentence)
        {
            return false;
        }
    }
}

//Guide: https://www.youtube.com/watch?v=anTP-mgktiI&ab_channel=OverSeasMedia
