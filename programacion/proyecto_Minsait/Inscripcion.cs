using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Inscripcion
    {
        // Atributos
        private Evento even;
        private Usuario participante;

        // Constructor
        public Inscripcion(Evento e, Usuario usu)
        {
            even = e;
            participante = usu;
        }

        public Evento Even { get { return even; } }
    }
}
