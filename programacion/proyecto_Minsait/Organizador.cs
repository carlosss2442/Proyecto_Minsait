using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Organizador
    {
        // Atributos
        private string nombre;
        private string correo;
        private List<Evento> eventoss;

        // Constructor
        public Organizador(string nom, string correo)
        {
            nombre = nom;
            this.correo = correo;
            eventoss = new List<Evento>(); 
        }

        // Propiedades y metodos

        private void CrearEvento(string nom, DateTime fe, int tiempo, Ubicacion ubi, Categoria cat)
        {
            Evento even = new Evento(nom, fe, tiempo, cat, ubi);
            eventoss.Add(even);
            Eventos.AgregarEvento(even);

        }

        private void EliminarEvento(int idEven)
        {
            Evento e = Eventos.BuscarEventoPorId(idEven);
            if (e != null)
            {
                eventoss.Remove(e);
                Eventos.CancelarEvento(e);
            }
        }
    }
}
