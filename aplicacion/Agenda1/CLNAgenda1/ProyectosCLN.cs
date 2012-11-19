using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;

namespace CLNAgenda1
{
    public class ProyectosCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        public ProyectosCLN()
        {
        }

        public void crearProyecto(Proyecto p)
        {
            contexto.Proyectos.AddObject(p);
            contexto.SaveChanges();
        }
        public Boolean modificarProyecto(Proyecto p)
        {
            try
            {
                contexto.Proyectos.Attach(p);
                contexto.ObjectStateManager.ChangeObjectState(p, System.Data.EntityState.Modified);
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Proyecto> listar()
        {
            var proy = contexto.Proyectos;
            return proy.ToList();
        }

        public IQueryable<object> listarNombres()
        {
            var resultado = from consulta in contexto.Proyectos
                            select new
                            {
                                consulta.Nombre,
                            };
            return resultado;
        }

        public Proyecto getProyecto(String nombre)
        {
            Proyecto p = new Proyecto();
            p = contexto.Proyectos.FirstOrDefault(consulta => consulta.Nombre == nombre);
            return p;
        }

        public Proyecto getProyectoId(int id)
        {
            Proyecto p = new Proyecto();
            p = contexto.Proyectos.FirstOrDefault(consulta => consulta.id == id);
            return p;
        }
        public IQueryable<object> seleccionar(String nombre)
        {
            var resultado = (from p in contexto.Proyectos
                             where p.Nombre.StartsWith(nombre)
                             select p.Nombre);
            return resultado;
        }
    }
}
