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

            if (!File.Exists("./" + nameDB))
            {
                try
                {
                    SQLiteConnection.CreateFile(nameDB);
                    BD.SQLiteModel.CrearModelo(this);

                    System.Console.WriteLine(">> Creada la base de datos: " + nameDB);
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
    }
}

//Guide: https://www.youtube.com/watch?v=anTP-mgktiI&ab_channel=OverSeasMedia
