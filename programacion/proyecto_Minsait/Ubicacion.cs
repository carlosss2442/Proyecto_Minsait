using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Ubicacion
    {
        // Atributos
        private bool es_online;
        private string descripcion;
        private DateTime fecha;

        // Constructor 
        public Ubicacion(bool onli, string descrip, DateTime fe)
        {
            es_online = onli;
            descripcion = descrip;
            fecha = fe;
        }

        // Propiedades y Metodos
        public bool Es_online { get { return es_online; } }
        public string Descripcion { get { return descripcion; } }
        public DateTime Fecha { get { return fecha; } }

    }
}
