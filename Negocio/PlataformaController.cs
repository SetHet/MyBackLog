using BD;
using Datos;
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
            DataBase db = new DataBase();
            bool insert;
            string nonQuery = "Insert into plataforma (titulo, descripcion) values ('"+plataforma.Titulo+"', '"+plataforma.Descripcion+"')";
            insert = db.NonQuery(nonQuery);
            return insert;
        }       
        public static bool eliminarPlataforma(int id_plataforma)
        {
            bool delete;
            DataBase db = new DataBase();
            string nonQuery = "Delete from plataforma where id_plataforma = " + id_plataforma;
            delete = db.NonQuery(nonQuery);
            return delete;
        }
        public static List<object[]> verPlataforma()
        {
            DataBase db = new DataBase();
            string nonQuery = "Select id_plataforma, titulo, descripcion from plataforma";
            List<object[]> datos = db.Select(nonQuery);
            return datos;
        }
    }
}
