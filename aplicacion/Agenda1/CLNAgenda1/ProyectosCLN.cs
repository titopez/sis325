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
        public void modificarProyecto(Proyecto p)
        {
            contexto.Proyectos.ApplyCurrentValues(p);
            contexto.SaveChanges();
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
    }
}
