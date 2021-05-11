using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Adquision
    {
        int id_progresion;
        string nombre_adquision;

        public int Id_progresion { get => id_progresion; set => id_progresion = value; }
        public string Nombre_adquision { get => nombre_adquision; set => nombre_adquision = value; }

        public override string ToString()
        {
            return $"id progresion: {Id_progresion}, nombre adquision: {Nombre_adquision}";
        }
    }
}
