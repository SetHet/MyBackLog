using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BD
{
    public static class SQLiteModel
    {
        public static string path_import = "./exportedDB.sql";

        public static void CrearModelo(BD.DataBase db)
        {
            Import(db, path_import);
        }

        public static void CreateTables()
        {

        }

        public static void StartLogs()
        {

        }

        public static void Import(BD.DataBase db, string path_import)
        {
            if (File.Exists(path_import)) Console.WriteLine("Exported found");
            else
            {
                Console.WriteLine("Exported not found");
                return;
            }
            
            //Leer archivo creador (exportacion)
            string import = File.ReadAllText(path_import);

            //Load in db import file
            db.LoadStatement(import);

        }
    }
}
