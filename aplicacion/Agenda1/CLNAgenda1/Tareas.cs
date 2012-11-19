using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CADAgenda1;
namespace CLNAgenda1
{
    public class Tareas
    {
        ScrumBDModelContainer contexto = new ScrumBDModelContainer();
        public Tareas()
        {

        }
        public void insertarTarea(Tarea tarea)
        {
            contexto.AddToTareas(tarea);
            contexto.SaveChanges();
        }
        public Boolean modificarTarea(Tarea tarea)
        {
            try
            {
                contexto.Tareas.ApplyCurrentValues(tarea);
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
