using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Nota
    {
        int id_nota;
        string descripcion;
        bool completado;

        public int Id_nota { get => id_nota; set => id_nota = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Completado { get => completado; set => completado = value; }

        public override string ToString()
        {
            return $"id nota: {Id_nota}, descripcion: {Descripcion}, completado: {Completado}";
        }
    }
}
