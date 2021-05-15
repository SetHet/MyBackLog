using BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PlataformaController
    {
        public static bool insertarPlataforma (Plataforma plataforma)
        {
            BD.DataBase db = new DataBase();
            bool insert;
            string nonQuerry = "Insert into plataforma (titulo, descripcion) values ('" + plataforma.Titulo + "','" + plataforma.Descripcion + "')";
            insert = db.NonQuery(nonQuerry);
            return insert;
        }       
    }
}
