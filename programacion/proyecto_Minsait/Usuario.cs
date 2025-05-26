using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Usuario
    {
        // Atributos
        private int id;
        private string nombre;
        private string email;
        private string contrasenya;
        private List<Evento> eventos;


        // Constructor 

        public Usuario(int id, string nom, string correo, string pass)
        {
            this.id = id;
            nombre = nom;
            email = correo;
            contrasenya = pass;
        }


        // Propiedades y metodos

        public void inscribirEvento(Evento even)
        {
            eventos.Add(even);
        }

        public void cancelarInscripcion(Evento e)
        {
            foreach (Evento even in eventos)
            {
                if (even == e)
                {
                    eventos.Remove(even);
                    even.CancelarEvento();
                    Console.WriteLine("Inscripcion cancelada");
                } else
                {
                    Console.WriteLine("El usuario no esta inscrito en ese evento");
                }
            }
            
        }

        public List<Evento> obtenerEventosInscritos()
        {
            return eventos;
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }


    }




}
