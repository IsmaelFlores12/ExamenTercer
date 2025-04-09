using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTercer
{
    internal class Consola
    {
       public Consola() { }

        public Consola(int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            ID = iD;
            this.nombre = nombre;
            FechaRegistro = fechaRegistro;
            this.activo = activo;
        }

        public int ID { get; set; }
        public string nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool activo { get; set; }
    }
}
