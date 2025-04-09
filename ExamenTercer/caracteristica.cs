using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTercer
{
    internal class caracteristica:Consola
    {
        public caracteristica() { }
        public caracteristica(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
            : base(iD, nombre, fechaRegistro, activo)
        {
            this.colorInterfaz = colorInterfaz;
        }

        public string colorInterfaz { get; set; }
    
    }
}
