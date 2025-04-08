using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTercer
{
    internal class Usuarios
    {
        public Usuarios() { }
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NomUsuario="Ismael Flores",ContraUsuario="1213"},
            new Usuarios{NomUsuario="Wendy Plascencia",ContraUsuario="1234"},
        };
        public List<Usuarios> obtenerUsuario()
        {
            return usuarios;

        }



        public string NomUsuario { get; set; }
        public string ContraUsuario { get; set; }
    }
}
