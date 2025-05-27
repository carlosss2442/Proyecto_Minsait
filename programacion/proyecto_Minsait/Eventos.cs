using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Eventos
    {
        // Atributos
        private static List<Evento> listaEventos = new List<Evento>();

        // Metodos

        public static void AgregarEvento(Evento e)
        {
            listaEventos.Add(e);
        }

        public static void CancelarEvento(Evento e)
        {
            listaEventos.Remove(e);
        }

        public static void ListarEventos()
        {
            foreach (var e in listaEventos)
            {
                Console.WriteLine($"ID: {e}, Nombre: {e}, Fecha: {e}");
            }
        }

        public static Evento BuscarEventoPorId(int id)
        {
            foreach (Evento ev in listaEventos)
            {
                if (ev.Id == id)
                {
                    return ev;
                }
            }
            return null;
        }
    }
}
