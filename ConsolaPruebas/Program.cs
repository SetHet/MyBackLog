﻿using System;
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
            BD.DataBase db = new BD.DataBase();

            

            db.DeleteDataBase();
            Console.Read();
        }
    }
}
