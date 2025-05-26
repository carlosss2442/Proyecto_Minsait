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
        private int id;
        private string nombre;
        private DateTime fecha;
        private int duracion;
        private Categoria categoria;
        private Ubicacion ubicacion;
        private Organizador organizador;
        private bool cancelado;
        private List<Usuario> usuarios;

        // Constructor
        public Evento(int id, string nom, DateTime fecha, int dura, Categoria cate, Ubicacion ubi)
        {
            this.id = id;
            nombre = nom;
            this.fecha = fecha;
            this.duracion = dura;
            this.categoria = cate;
            this.ubicacion = ubi;
            usuarios = new List<Usuario>();
            cancelado = false;
        }

        // Metodos 

        public void RegistrarUsuario(Usuario usu)
        {
            
           if (!cancelado && !usuarios.Contains(usu))
           {
                usuarios.Add(usu);
           }
            
        }

        public void CancelarEvento()
        {
            cancelado = true;
            usuarios.Clear();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public void MostrarIntegrantes()
        {
            foreach (Usuario usu in usuarios)
            {
                Console.WriteLine(usu.Nombre);
            }
        }

        public void cancelarParticipacion(Usuario usuario)
        {
            if (usuarios.Remove(usuario))
            {
                Console.WriteLine("Participante eliminado.");
            }
            else
            {
                Console.WriteLine("El participante no estaba registrado.");
            }
        }

    }
}
