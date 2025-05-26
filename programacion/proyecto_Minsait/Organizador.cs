using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Organizador
    {
        private string nombre;
        private int id;
        private List<Evento> eventoss;

        public Organizador(string nom, int id)
        {
            nombre = nom;
            this.id = id;
            eventoss = new List<Evento>(); 
        }
    }
}
