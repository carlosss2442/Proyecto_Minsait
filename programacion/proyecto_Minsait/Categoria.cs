using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Minsait
{
    class Categoria
    {
        // Atributos
        private string nombre;
        private string descripcion;

        // Categoria
        public Categoria(string nom, string descrip)
        {
            nombre = nom;
            descripcion = descrip;
        }

        // Propiedades y metodos
        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }


    }
}
