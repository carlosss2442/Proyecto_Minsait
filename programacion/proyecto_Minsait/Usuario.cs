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
        private List<Inscripcion> inscripciones;


        // Constructor 

        public Usuario(int id, string nom, string correo, string pass)
        {
            this.id = id;
            nombre = nom;
            email = correo;
            contrasenya = pass;
        }


        // Propiedades y metodos

        public void InscribirseAEvento(int id)
        {
            Evento even = Eventos.BuscarEventoPorId(id);
            if (even != null)
            {
                Inscripcion inns = new Inscripcion(even, this);
                even.AgregarInscripcion(inns);
                inscripciones.Add(inns);
            }
        }

        public void CancelarInscripcion(int id)
        {
            Evento even = Eventos.BuscarEventoPorId(id);
            if ( even != null)
            {
                Inscripcion insc = null;
                foreach (Inscripcion ins in inscripciones)
                {
                    if (ins.Even == even)
                    {
                        insc = ins;
                        break;
                    }

                }

                if (insc != null)
                {
                    even.EliminarInscripcion(insc);
                    inscripciones.Remove(insc);
                } else
                {
                    Console.WriteLine("No estas inscrito en en este Evento ({0})", insc.Even);
                }
            }else
            {
                Console.WriteLine("Evento no Encontrado");
            }
        }

        public void MostrarIncriociones()
        {
            foreach (var i  in inscripciones)
            {
                Console.WriteLine("Evento: {0} ", i.Even.Nombre);
            }
        }


    }




}
