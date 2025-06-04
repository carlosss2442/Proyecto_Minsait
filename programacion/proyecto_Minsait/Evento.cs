using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Evento
    {
        // Atributos
        private static int contadorId = 0;
        private int id;
        private string nombre;
        private DateTime fecha;
        private int duracion;
        private Categoria categoria;
        private Ubicacion ubicacion;
        private Organizador organizador;
        private List<Inscripcion> inscripciones;

        // Constructor
        public Evento(string nom, DateTime fecha, int dura, Categoria cate, Ubicacion ubi)
        {
            id = ++contadorId;
            nombre = nom;
            this.fecha = fecha;
            this.duracion = dura;
            this.categoria = cate;
            this.ubicacion = ubi;
            inscripciones = new List<Inscripcion>();
           
        }

        // Metodos  Y propiedades

        public void MoatrarIncripciones()
        {
            
           foreach (var ins in inscripciones)
           {
                Console.WriteLine(ins);
           }
            
        }

        public void AgregarInscripcion(Inscripcion ins)
        {
            inscripciones.Add(ins);
        }

        public void EliminarInscripcion(Inscripcion ins)
        {
            inscripciones.Remove(ins);
        }
        
        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
    }
}
