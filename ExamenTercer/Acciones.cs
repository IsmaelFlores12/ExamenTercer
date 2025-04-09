using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTercer
{
    internal class Acciones
    {
        public Acciones() { }

        caracteristica C = new caracteristica();
        List<caracteristica> Listaproducto = new List<caracteristica>
        {
            new caracteristica("Rojo",1213,"Pokemon",DateTime.Today,true),
            new caracteristica("Verde",1215,"ZELDA",DateTime.Today,true),
        };
        public List<caracteristica> mostrar()
        {
            return Listaproducto;
        }
        public bool eliminarP(int ID)
        {
            try
            {
                var objetoEliminar = Listaproducto.Find(x => x.ID == ID);
                if (objetoEliminar != null)
                {
                    Listaproducto.Remove(objetoEliminar);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public bool insertar(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            try
            {
                Listaproducto.Add(new caracteristica(C.colorInterfaz = colorInterfaz,C.ID=iD,C.nombre=nombre,C.FechaRegistro=fechaRegistro,C.activo=activo));
                return true;

            }
            catch (Exception) 

            { return false; }
        }

        public bool actualizar(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            try
            {
                var objetoActualizar = Listaproducto.Find(x => x.ID == iD);
                if (objetoActualizar != null)
                {
                    objetoActualizar.colorInterfaz = colorInterfaz;
                    objetoActualizar.ID = iD;
                    objetoActualizar.nombre = nombre;
                    objetoActualizar.FechaRegistro = fechaRegistro;
                    objetoActualizar.activo = activo;
                    return true;
                }
                return true;
            }
            catch { return false; }
        }




    }
}
