using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;

namespace CLNAgenda1
{
    public class TareaCLN
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();

        public TareaCLN()
        {
        }

        public void crearTarea(Tarea t)
        {
            contexto.AddToTareas(t);
            contexto.SaveChanges();
        }

        public void eliminarTarea(Tarea t)
        {
            contexto.DeleteObject(t);
            contexto.SaveChanges();
        }

        public List<Tarea> listarTareas()
        {
            var t = contexto.Tareas;
            return t.ToList();
        }

        public void modificarTarea(Tarea t)
        {
            contexto.Tareas.ApplyCurrentValues(t);
            contexto.SaveChanges();
        }

        public Tarea buscarTarea(int id)
        {
            Tarea t = new Tarea();
            t = contexto.Tareas.FirstOrDefault(consulta => consulta.id_tarea == id);
            return t;
        }
    }
}
