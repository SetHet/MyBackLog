using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Libro
    {
        int cantidad_paginas;
        int pagina;

        public int Cantidad_paginas { get => cantidad_paginas; set => cantidad_paginas = value; }
        public int Pagina { get => pagina; set => pagina = value; }

        public override string ToString()
        {
            return $"Paginas totales: {Cantidad_paginas}, Pagina: {Pagina}";
        }
    }
}
