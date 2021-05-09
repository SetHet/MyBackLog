using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Pelicula
    {
        int duracion_minutos;
        int minuto;

        public int Duracion_minutos { get => duracion_minutos; set => duracion_minutos = value; }
        public int Minuto { get => minuto; set => minuto = value; }

        public override string ToString()
        {
            return $"Minutos totales: { Duracion_minutos}, Minuto: {Minuto}";
        }
    }
}
